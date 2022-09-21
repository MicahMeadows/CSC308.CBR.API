using Models;

namespace Data.Match;

public interface IMatchDataObject
{
    Task<Models.Match> CreateNewMatch();
    Task PostMatchResults(Models.MatchResult matchResult);
}