using Microsoft.AspNetCore.Mvc;
using MusicStoreApi.Models;
using MusicStoreApi.Services;

namespace MusicStoreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SongsController : ControllerBase
{
    private readonly SongGenerator _songGenerator;

    public SongsController(SongGenerator songGenerator)
    {
        _songGenerator = songGenerator;
    }
    [HttpGet]
    public IActionResult GetSongs(
        [FromQuery] long seed = 12345,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] double likesValue = 0.0,
        [FromQuery] string locale = "en-US")
    {
        // Validate parameters
        if (page < 1)
        {
            return BadRequest(new { error = "Page must be greater than 0" });
        }

        if (pageSize < 1 || pageSize > 100)
        {
            return BadRequest(new { error = "PageSize must be between 1 and 100" });
        }

        if (likesValue < 0.0 || likesValue > 10.0)
        {
            return BadRequest(new { error = "LikesValue must be between 0.0 and 10.0" });
        }

        var songs = _songGenerator.GenerateSongs(seed, page, pageSize, likesValue, locale);
        return Ok(songs);
    }
}