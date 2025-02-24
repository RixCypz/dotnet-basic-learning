using LearningService.Models;
using LearningService.Models.Entities;

namespace LearningService.Services;

public interface IBookService
{
    Task<Book?> GetBookByIdAsync(int id);
    Task<IEnumerable<Book?>> GetAllBooksAsync();
    Task AddBookAsync(Book book);
    Task UpdateBookAsync(Book book);
    Task DeleteBookAsync(int id);
}