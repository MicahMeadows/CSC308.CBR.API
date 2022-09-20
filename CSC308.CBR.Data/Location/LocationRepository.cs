namespace Data.Location;
using System.Collections.Generic;
using Models;

public class LocationRepository : ILocationRepository
{
    private readonly List<Location> _items = new List<Location>()
    {
        new Location() { Name = "wallace", Description = "good building" },
        new Location() { Name = "combs", Description = "bad building" },
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
}