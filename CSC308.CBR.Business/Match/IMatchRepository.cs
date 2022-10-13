using Models;

namespace Business.Match;

public interface IMatchRepository
{
    Task<Models.Match> CreateNewMatch();
    Task PostMatchResults(Models.MatchResult matchResult);
    Task<IEnumerable<Models.Match>> GetMatchesForLocation(Models.Location location);
    Task<IEnumerable<Models.MatchResult>> GetMatchResultsForLocation(Models.Location location);
}