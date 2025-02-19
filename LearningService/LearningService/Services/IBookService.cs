using LearningService.Models;

namespace LearningService.Services
{
    public interface IBookService
    {
        Task<Book> GetBookByIdAsync(int id);
    }
}
