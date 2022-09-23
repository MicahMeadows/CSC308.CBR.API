using Models;

namespace Data.Match;

public class MatchDataObject : IMatchDataObject
{
    private readonly global::Data.Location.ILocationDataObject _locationDataObject;

    public MatchDataObject(global::Data.Location.ILocationDataObject locationDataObject)
    {
        _locationDataObject = locationDataObject;
    }
    
    public async Task<Models.Match> CreateNewMatch()
    {
        var redTeam = await _locationDataObject.GetRandomLocation();
        var blueTeam = await _locationDataObject.GetRandomLocation(new List<Models.Location>()
        {
            redTeam
        });
        
        var newMatch = new Models.Match() { RedTeam = redTeam, BlueTeam = blueTeam, MatchID = Guid.NewGuid().ToString() };
        
        return newMatch;
    }

    public async Task PostMatchResults(MatchResult matchResult)
    {
        var winner = await _locationDataObject.GetLocationByName(matchResult.Winner.Name);
        var loser = await _locationDataObject.GetLocationByName(matchResult.Loser.Name);
        winner.Rating++;
        loser.Rating--;
        await Task.Delay(0);
    }
}