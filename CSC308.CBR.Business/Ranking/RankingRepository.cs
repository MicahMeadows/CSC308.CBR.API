using System.Runtime.InteropServices.ComTypes;
using Business.Location;
using Models.Exception;

namespace Business.Ranking;
using Models;

public class RankingRepository : IRankingRepository
{
    private readonly ILocationRepository _locationRepository;

    public RankingRepository(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }
    
    private async Task<IEnumerable<Models.Ranking>> GetRankedLocations()
    {
        var locations = await _locationRepository.GetAllLocations();
        locations = locations.OrderBy(e => e.Rating).Reverse();
        return locations.Select((location, idx) => new Models.Ranking(){Location = location, Rank = idx});
    }
    
    public async Task<Models.Ranking> GetLocationRank(Models.Location location)
    {
        var rankedLocations = await GetRankedLocations();
        try
        {
            return rankedLocations.First(rankedLocation => rankedLocation.Location.Name.Equals(location.Name));
        }
        catch (Exception)
        {
            throw new NoRankingForLocationException();
        }
    }

    public async Task<IEnumerable<Models.Ranking>> GetRankings(int? take, int? skip)
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
