using LearningService.Models;
using LearningService.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearningService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController(IBookService bookService) : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetBookById(int id)
    {
        var book = await bookService.GetBookByIdAsync(id);
        if (book == null) return NotFound();
        return Ok(book);
    }
        
    [HttpPost]
    public async Task<IActionResult> AddBook([FromBody] Book book)
    {
        await bookService.AddBookAsync(book);
        return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateBook(int id, [FromBody] Book book)
    {
        if (id != book.Id) return BadRequest();
        await bookService.UpdateBookAsync(book);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        await bookService.DeleteBookAsync(id);
        return NoContent();
    }
}