using LearningService.Models;

namespace LearningService.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetBookByIdAsync(int id);
    }
}
