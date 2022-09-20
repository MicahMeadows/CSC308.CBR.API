using System.Runtime.ExceptionServices;
using Models.Exception;

namespace Business.Location;
using System.Collections.Generic;
using Models;

public class LocationRepository : ILocationRepository
{
    private readonly List<Location> _items = new List<Location>()
    {
        new Location() { Name = "wallace", Description = "good building", ImageUrl = "test" },
        new Location() { Name = "combs", Description = "bad building", ImageUrl = "test" },
    };
    public async Task<IEnumerable<Location>> GetAllLocations()
    {
        await Task.Delay(0);
        return _items;
    }

    public async Task<Location> GetLocationByName(string name)
    {
        await Task.Delay(0);
        return _items.First(e => e.Name.Equals(name));
    }

    public async Task<Location> GetRandomLocation(List<Location>? blacklist)
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