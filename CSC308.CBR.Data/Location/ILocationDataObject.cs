namespace Data.Location;
using Models;
public interface ILocationDataObject
{
    Task<IEnumerable<Location>> GetAllLocations();
    Task<Location> GetLocationByName(string name);
    Task<Location> GetRandomLocation(List<Location>? blacklist = null);
}