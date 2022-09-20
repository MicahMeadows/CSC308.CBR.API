using Business.Match;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Exception;

namespace CSC308.CBR.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MatchController : ControllerBase
{
    private readonly IMatchRepository _matchRepository;

    public MatchController(IMatchRepository matchRepository)
    {
        _matchRepository = matchRepository;
    }
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Models.Match))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetMatch()
    {
        try
        {
            var newMatch = await _matchRepository.CreateNewMatch();
            return Ok(newMatch);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> PostMatchResults(MatchResult matchResult)
    {
        try
        {
            await _matchRepository.PostMatchResults(matchResult);
            return Ok("Match results logged.");
        }
        catch (MatchNotFoundException ex)
        {
            return NotFound("Match not found");
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}