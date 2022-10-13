using AutoMapper;
using DataObjects;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Exception;
using DataObjects.Queries;

namespace Data.Location;

public class SqlLocationDataObject : ILocationDataObject
{
    private readonly CBRContext _context;
    private readonly IMapper _mapper;

    public SqlLocationDataObject(CBRContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }
    
    public async Task<IEnumerable<Models.Location>> GetAllLocations()
    {
        var dbLocations = await _context.Locations.AsNoTracking().ToListAsync();
        return _mapper.Map<IEnumerable<Models.Location>>(dbLocations);
    }

    public async Task<Models.Location> GetLocationByName(string name)
    {
        try
        {
            var dbLocationWithName = await _context.Locations.AsNoTracking().FirstAsync(e => e.Name == name);
            return _mapper.Map<Models.Location>(dbLocationWithName);
        }
        catch (Exception ex)
        {
            throw new MatchNotFoundException();
        }
    }

    public async Task<Models.Location> GetRandomLocation(List<Models.Location>? blacklist = null)
    {
        DbLocation randomLocation;
        if (blacklist == null)
        {
            randomLocation = await _context.GetRandomLocation();
        }
        else
        {
            var sqlBlacklist = _mapper.Map<IEnumerable<DbLocation>>(blacklist);
            randomLocation = await _context.GetRandomLocation(sqlBlacklist);
        }
        return _mapper.Map<Models.Location>(randomLocation);
    }

    public async Task<Models.Location> GetLocationbyID(string id)
    {
        var dbLocation = await _context.Locations.FirstAsync(x => x.ID.ToString().Equals(id));
        return _mapper.Map<Models.Location>(dbLocation);
    }
}