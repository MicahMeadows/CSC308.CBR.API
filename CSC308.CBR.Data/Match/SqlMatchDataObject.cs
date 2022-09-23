using AutoMapper;
using Data.Location;
using DataObjects;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Match;

public class SqlMatchDataObject : IMatchDataObject
{
    private readonly IMapper _mapper;
    private readonly CBRContext _context;
    private readonly ILocationDataObject _locationDataObject;

    public SqlMatchDataObject(
        IMapper mapper, 
        CBRContext context, 
        ILocationDataObject locationDataObject
    ) {
        _mapper = mapper;
        _context = context;
        _locationDataObject = locationDataObject;
    }
    
    public async Task<Models.Match> CreateNewMatch()
    {
        var randomRedTeam = await _locationDataObject.GetRandomLocation();
        var blacklist = new List<Models.Location>() {
            randomRedTeam
        };
        var randomBlueTeam = await _locationDataObject.GetRandomLocation(blacklist);
        
        var newDbMatch = new DbMatch()
        {
            CreationTime = DateTime.Now,
            RedTeamID = new Guid(randomRedTeam.ID),
            BlueTeamID = new Guid(randomBlueTeam.ID),
        };
        
        await _context.Matches.AddAsync(newDbMatch);
        await _context.SaveChangesAsync();
        
        return _mapper.Map<Models.Match>(newDbMatch);
    }

    public async Task PostMatchResults(MatchResult matchResult)
    {
        throw new NotImplementedException();
    }
}