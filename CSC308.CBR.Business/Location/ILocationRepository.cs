namespace Business.Location;
using Models;
public interface ILocationRepository
{
    Task<IEnumerable<Location>> GetAllLocations();
    Task<Location> GetLocationByName(string name);
    Task<Location> GetRandomLocation(List<Location>? blacklist = null);
    Task<LocationDetails> GetLocationDetails(string id);
}