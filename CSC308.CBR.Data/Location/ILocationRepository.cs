namespace Data.Location;
using Models;
public interface ILocationRepository
{
    Task<IEnumerable<Location>> GetAllLocations();
    Task<Location> GetLocationByName(string name);
}