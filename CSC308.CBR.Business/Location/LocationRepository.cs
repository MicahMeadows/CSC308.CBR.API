using System.Runtime.ExceptionServices;
using Data.Location;
using Models.Exception;

namespace Business.Location;
using System.Collections.Generic;
using Models;

public class LocationRepository : ILocationRepository
{
    private readonly ILocationDataObject _locationDataObject;

    public LocationRepository(ILocationDataObject locationDataObject)
    {
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
}