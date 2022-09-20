using System.Runtime.InteropServices.ComTypes;
using Data.Location;

namespace Data.Ranking;
using Models;

public class RankingRepository : IRankingRepository
{
    private readonly ILocationRepository _locationRepository;

    public RankingRepository(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }

    async Task<IEnumerable<Ranking>> GetRankedLocations()
    {
        var locations = await _locationRepository.GetAllLocations();
        return locations.Select((location, idx) => new Ranking(){Location = location, Rank = idx});
    }
    
    public async Task<Ranking> GetLocationRank(Location location)
    {
        var rankedLocations = await GetRankedLocations();
        return rankedLocations.First(rankedLocation => rankedLocation.Location.Name.Equals(location.Name));
    }

    public async Task<IEnumerable<Ranking>> GetRankings(int? take, int? skip)
    {
        if (take == null && skip == null)
        {
            return await GetRankedLocations();
        }
        
        var rankedLocations = await GetRankedLocations();
        if (skip is not null)
        {
            rankedLocations = rankedLocations.Skip(skip.Value);
        }

        if (take is not null)
        {
            rankedLocations = rankedLocations.Take(take.Value);
        }

        return rankedLocations;
    }
}
