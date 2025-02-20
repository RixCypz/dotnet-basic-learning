using LearningService.Models.Request;
using LearningService.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearningService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenreController(IGenreService genreService) : ControllerBase
{
    [HttpPost("get")]
    public async Task<IActionResult> GetGenreByCode([FromBody] GenreRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var genre = await genreService.GetGenreByCodeAsync(request.Code);
        if (genre == null) return NotFound("Genre not found.");
        
        return Ok(genre);
    }

    [HttpPost]
    public async Task<IActionResult> GetAllGenres([FromForm] int page = 1, [FromForm] int pageSize = 10)
    {
        if(page <= 0 || pageSize <= 0) return BadRequest("Page and PageSize are required.");
        
        var genres = await genreService.GetAllGenres(page, pageSize);
        return Ok(genres);
    }
}