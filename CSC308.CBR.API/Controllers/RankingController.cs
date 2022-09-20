using Data.Ranking;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace CSC308.CBR.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RankingController : ControllerBase
{
    private readonly IRankingRepository _rankingRepository;

    public RankingController(IRankingRepository rankingRepository)
    {
        _rankingRepository = rankingRepository;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Ranking>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllRankings(int? take, int? skip)
    {
        try
        {
            var allRankings = await _rankingRepository.GetRankings(take, skip);
            
        
            return Ok(allRankings);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
    
}