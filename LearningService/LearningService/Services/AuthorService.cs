using LearningService.Models;
using LearningService.Models.Entities;
using LearningService.Repositories;

namespace LearningService.Services;

public class AuthorService(IAuthorRepository authorRepository) : IAuthorService
{
    public async Task<Author?> GetAuthorByIdAsync(int id)
    {
        return await authorRepository.GetAuthorByIdAsync(id);
    }

    public async Task<IEnumerable<Author?>> GetAllAuthorsAsync()
    {
        return await authorRepository.GetAllAuthorsAsync();
    }
}