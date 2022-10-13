using Business.Match;
using Business.Ranking;
using Data.Location;
using Data.Match;

namespace Business.Location;
using System.Collections.Generic;
using Models;

public class LocationRepository : ILocationRepository
{
    private readonly ILocationDataObject _locationDataObject;
    private readonly IRankingRepository _rankingRepository;
    private readonly IMatchDataObject _matchDataObject;

    public LocationRepository(ILocationDataObject locationDataObject, IRankingRepository rankingRepository, IMatchDataObject matchDataObject)
    {
        _matchDataObject = matchDataObject;
        _rankingRepository = rankingRepository;
        _locationDataObject = locationDataObject;
    }
    
    public async Task<IEnumerable<Location>> GetAllLocations()
    {
        return await _locationDataObject.GetAllLocations();
    }

    public async Task<Location> GetLocationByName(string name)
    {
        return await _locationDataObject.GetLocationByName(name);
    }

    public async Task<Location> GetRandomLocation(List<Location>? blacklist = null)
    {
        return await _locationDataObject.GetRandomLocation(blacklist);
    }

    public async Task<LocationDetails> GetLocationDetails(string id)
    {
        var locationRanking = await _rankingRepository.GetLocationRank(id);
        var locationMatchResults = await _matchDataObject.GetMatchResultsForLocation(locationRanking.Location);
        var matchWins = locationMatchResults.Where(x => x.Winner.ID.ToString().Equals(id));

        var newLocationDetails = new LocationDetails()
        {
            Location = locationRanking.Location,
            Rank = locationRanking.Rank,
            MatchCount = locationMatchResults.Count(),
            WinCount = matchWins.Count()
        };

        return newLocationDetails;
    }
}