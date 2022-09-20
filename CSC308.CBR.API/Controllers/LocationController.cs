using Models;
using Business.Location;
using Microsoft.AspNetCore.Mvc;
using Models.Exception;

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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Location))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetRandomLocation(List<Location> blacklist)
        {
            try
            {
                var randomLocation = await _locationRepository.GetRandomLocation(blacklist);
                return Ok(randomLocation);
            }
            catch (NoLocationsAvailableException ex)
            {
                return NotFound("No random location available.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Location>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
