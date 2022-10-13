using Data.Match;
using Models;

namespace Business.Match;

public class MatchRepository : IMatchRepository
{
    private readonly IMatchDataObject _matchDataObject;

    public MatchRepository(IMatchDataObject matchDataObject)
    {
        _matchDataObject = matchDataObject;
    }

    public async Task<Models.Match> CreateNewMatch()
    {
        return await _matchDataObject.CreateNewMatch();
    }

    public async Task PostMatchResults(MatchResult matchResult)
    {
        await _matchDataObject.PostMatchResults(matchResult);
    }

    public async Task<IEnumerable<Models.Match>> GetMatchesForLocation(Models.Location location)
    {
        var matches = await _matchDataObject.GetMatchesForLocation(location);
        return matches;
    }

    public async Task<IEnumerable<MatchResult>> GetMatchResultsForLocation(Models.Location location)
    {
        var matchResults = await _matchDataObject.GetMatchResultsForLocation(location);
        return matchResults;
    }
}