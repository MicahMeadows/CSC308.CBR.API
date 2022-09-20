using Models;
using Data.Location;
using Microsoft.AspNetCore.Mvc;

namespace CSC308.CBR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;
        
        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Location>))]
        public async Task<IActionResult> GetAllLocations()
        {
            try
            {
                var loadedLocations = await _locationRepository.GetAllLocations();
                return Ok(loadedLocations);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
    }
}
