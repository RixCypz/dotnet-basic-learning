using LearningService.Data;
using LearningService.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningService.Repositories;

public class BookRepository(ApplicationDbContext context) : IBookRepository
{
    public async Task<Book?> GetBookByIdAsync(int id)
    {
        return await context.Books.FindAsync(id);  
    }
    public async Task<IEnumerable<Book?>> GetAllBooksAsync()
    {
        return await context.Books.ToListAsync();
    }

    public async Task AddBookAsync(Book? book)
    {
        if (book != null) await context.Books.AddAsync(book);
        await context.SaveChangesAsync();
    }

    public async Task UpdateBookAsync(Book? book)
    {
        if (book != null) context.Books.Update(book);
        await context.SaveChangesAsync();
    }

    public async Task DeleteBookAsync(int id)
    {
        var book = await context.Books.FindAsync(id);
        if (book != null)
        {
            context.Books.Remove(book);
            await context.SaveChangesAsync();
        }
    }
}