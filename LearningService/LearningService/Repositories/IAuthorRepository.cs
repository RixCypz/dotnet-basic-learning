using LearningService.Models;

namespace LearningService.Repositories;

public interface IAuthorRepository
{
    Task<Author?> GetAuthorByIdAsync(int id);
    Task<IEnumerable<Author?>> GetAllAuthorsAsync();
}