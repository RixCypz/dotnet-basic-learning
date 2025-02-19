using LearningService.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearningService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController(IAuthorService authorService) : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetAuthorById(int id)
    {
        var author = await authorService.GetAuthorByIdAsync(id);
        if (author == null) return NotFound();
        return Ok(author);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAuthors()
    {
        var authors = await authorService.GetAllAuthorsAsync();
        return Ok(authors);
    }
}