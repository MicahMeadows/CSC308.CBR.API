namespace Business.Ranking;
using Models;

public interface IRankingRepository
{
    // get ranking of location
    Task<Ranking> GetLocationRank(Location location);
    
    // get rankings starting at [skip] and ending at [skip + take]
    Task<IEnumerable<Ranking>> GetRankings(int? take, int? skip);

}