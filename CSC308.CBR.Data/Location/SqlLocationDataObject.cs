using AutoMapper;
using DataObjects;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Exception;

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
            var dbLocationWithName = await _context.Locations.AsNoTracking().FirstAsync(e => e.name == name);
            return _mapper.Map<Models.Location>(dbLocationWithName);
        }
        catch (Exception ex)
        {
            throw new MatchNotFoundException();
        }
    }

    public async Task<Models.Location> GetRandomLocation(List<Models.Location>? blacklist = null)
    {
        var randomDbLocation = await _context.Locations.OrderBy(e => EF.Functions.Random()).FirstAsync();
        return _mapper.Map<Models.Location>(randomDbLocation);
    }
}