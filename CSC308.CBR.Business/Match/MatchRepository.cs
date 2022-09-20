using ILocationRepository = Business.Location.ILocationRepository;
using Models;

namespace Business.Match;

public class MatchRepository : IMatchRepository
{
    private readonly Location.ILocationRepository _locationRepository;

    public MatchRepository(Location.ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }
    
    public async Task<Models.Match> CreateNewMatch()
    {
        var redTeam = await _locationRepository.GetRandomLocation();
        var blueTeam = await _locationRepository.GetRandomLocation(new List<Models.Location>()
        {
            redTeam
        });
        
        var newMatch = new Models.Match() { RedTeam = redTeam, BlueTeam = blueTeam, MatchID = Guid.NewGuid().ToString() };
        
        return newMatch;
    }

    public async Task PostMatchResults(MatchResult matchResult)
    {
        var winner = await _locationRepository.GetLocationByName(matchResult.Winner.Name);
        var loser = await _locationRepository.GetLocationByName(matchResult.Loser.Name);
        winner.Rating++;
        loser.Rating--;
        await Task.Delay(0);
    }
}