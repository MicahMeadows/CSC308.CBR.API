using AutoMapper;
using CSC308.CBR.Core;
using DataObjects;
using DataObjects.Queries;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Exception;

namespace Data.Match;

public class SqlMatchDataObject : IMatchDataObject
{
    private readonly IMapper _mapper;
    private readonly CBRContext _context;

    public SqlMatchDataObject(
        IMapper mapper, 
        CBRContext context
    ) {
        _mapper = mapper;
        _context = context;
    }
    
    public async Task<Models.Match> CreateNewMatch()
    {
        var randomRedTeam = await _context.GetRandomLocation();
        var blacklist = new List<DbLocation>() {
            randomRedTeam
        };
        var randomBlueTeam = await _context.GetRandomLocation(blacklist);
        
        var newDbMatch = new DbMatch()
        {
            CreationTime = DateTime.Now,
            RedTeamID = randomRedTeam.ID,
            BlueTeamID = randomBlueTeam.ID,
            BlueTeamLocation = randomBlueTeam,
            RedTeamLocation = randomRedTeam,
        };
        
        await _context.Matches.AddAsync(newDbMatch);
        await _context.SaveChangesAsync();
        
        return _mapper.Map<Models.Match>(newDbMatch);
    }

    public async Task PostMatchResults(MatchResult matchResult)
    {
        var matchId = new Guid(matchResult.MatchID);

        DbMatch postedMatch;
        try
        {
            postedMatch = await _context
                .Matches
                .Include(x => x.RedTeamLocation)
                .Include(x => x.BlueTeamLocation)
                .AsNoTracking()
                .FirstAsync(e => e.ID == matchId);
        }
        catch (Exception ex)
        {
            throw new MatchNotFoundException();
        }
        
        var hasResults = await _context
            .MatchResults
            .AsNoTracking()
            .AnyAsync(e => e.MatchID == postedMatch.ID);

        if (hasResults) throw new MatchAlreadyHasResultsException();
        
        if (matchResult.Winner.ID == matchResult.Loser.ID) throw new WinnerIsLoserException();

        bool winnerRed = matchResult.Winner.ID == postedMatch.RedTeamLocation.ID.ToString();

        var dbWinner = winnerRed ? postedMatch.RedTeamLocation : postedMatch.BlueTeamLocation;
        var dbLoser = winnerRed ? postedMatch.BlueTeamLocation : postedMatch.RedTeamLocation;

        var newMatchResult = new DbMatchResult()
        {
            submit_time = DateTime.Now,
            Loser = dbLoser,
            Winner = dbWinner,
            MatchID = postedMatch.ID
        };

        try
        {
            var transaction = await _context.Database.BeginTransactionAsync();
            
            await _context.MatchResults.AddAsync(newMatchResult);

            var winnerCurrentRating = dbWinner.Rating;
            var loserCurrentRating = dbLoser.Rating;

            var winnerWinChance = RankingMath.WinChance(winnerCurrentRating, loserCurrentRating);
            var loserWinChance = RankingMath.WinChance(loserCurrentRating, winnerCurrentRating);

            var winnerRatingChange = RankingMath.WinnerNewRating(winnerWinChance, winnerCurrentRating);
            var loserRatingChange = RankingMath.LoserNewRating(loserWinChance, loserCurrentRating);
            
            await _context.ModifyRating(dbWinner.ID, winnerRatingChange);
            _context.Update(dbWinner);
            
            await _context.ModifyRating(dbLoser.ID, loserRatingChange);
            _context.Update(dbLoser);
            
            await _context.SaveChangesAsync();
            
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task<IEnumerable<Models.Match>> GetMatchesForLocation(Models.Location location)
    {
        var matches = await _context.Matches
            .Where(x =>
                x.BlueTeamID.ToString().Equals(location.ID) ||
                x.RedTeamID.ToString().Equals(location.ID))
            .ToListAsync();
        
        return _mapper.Map<List<Models.Match>>(matches);
    }

    public async Task<IEnumerable<MatchResult>> GetMatchResultsForLocation(Models.Location location)
    {
        var matchResults = await _context.MatchResults.Where(x =>
            x.WinnerID.ToString().Equals(location.ID) || x.LoserID.ToString().Equals(location.ID)).ToListAsync();

        return _mapper.Map<IEnumerable<MatchResult>>(matchResults);
    }
}