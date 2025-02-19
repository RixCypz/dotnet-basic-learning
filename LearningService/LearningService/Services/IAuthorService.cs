using LearningService.Models;

namespace LearningService.Services;

public interface IAuthorService
{
    Task<Author?> GetAuthorByIdAsync(int id);
    Task<IEnumerable<Author?>> GetAllAuthorsAsync();
    
}