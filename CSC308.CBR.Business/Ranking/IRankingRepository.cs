namespace Business.Ranking;
using Models;

public interface IRankingRepository
{
    // get ranking of location
    Task<Ranking> GetLocationRank(Location location);

    // get ranking of location with id
    Task<Ranking> GetLocationRank(string id);
    
    // get rankings starting at [skip] and ending at [skip + take]
    Task<IEnumerable<Ranking>> GetRankings(int? take, int? skip);

}