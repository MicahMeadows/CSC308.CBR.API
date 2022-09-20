using Models;

namespace Business.Match;

public interface IMatchRepository
{
    Task<Models.Match> CreateNewMatch();
    Task PostMatchResults(Models.MatchResult matchResult);
}