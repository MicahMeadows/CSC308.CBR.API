using Models.Exception;

namespace Data.Location;

public class LocationDataObject : ILocationDataObject
{
    private readonly List<Models.Location> _items = new List<Models.Location>()
    {
        new Models.Location() { Name = "wallace", Description = "good building", ImageUrl = "test" },
        new Models.Location() { Name = "combs", Description = "bad building", ImageUrl = "test" },
    };
    public async Task<IEnumerable<Models.Location>> GetAllLocations()
    {
        await Task.Delay(0);
        return _items;
    }

    public async Task<Models.Location> GetLocationByName(string name)
    {
        await Task.Delay(0);
        return _items.First(e => e.Name.Equals(name));
    }

    public async Task<Models.Location> GetRandomLocation(List<Models.Location>? blacklist)
    {
        var blacklistNames = blacklist?.Select(e => e.Name);
        
        var filteredItems = blacklistNames is null ? _items : _items.Where(e => !blacklistNames.Contains(e.Name)).ToList();
        
        if (filteredItems.Count == 0)
        {
            throw new NoLocationsAvailableException();
        }
        
        var randomLocation = filteredItems.ElementAt(new Random().Next(filteredItems.Count));

        await Task.Delay(0);

        return randomLocation;
    }
}