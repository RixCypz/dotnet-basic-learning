using LearningService.Models;
using LearningService.Models.Entities;

namespace LearningService.Repositories;

public interface IAuthorRepository
{
    Task<Author?> GetAuthorByIdAsync(int id);
    Task<IEnumerable<Author?>> GetAllAuthorsAsync();
}