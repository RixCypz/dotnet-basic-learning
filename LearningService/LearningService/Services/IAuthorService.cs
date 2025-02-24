using LearningService.Models;
using LearningService.Models.Entities;

namespace LearningService.Services;

public interface IAuthorService
{
    Task<Author?> GetAuthorByIdAsync(int id);
    Task<IEnumerable<Author?>> GetAllAuthorsAsync();
    
}