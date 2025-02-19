using LearningService.Data;
using LearningService.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningService.Repositories;

public class AuthorRepository(ApplicationDbContext context) : IAuthorRepository
{
    public async Task<Author?> GetAuthorByIdAsync(int id)
    {
        return await context.Authors.FindAsync(id);
    }

    public async Task<IEnumerable<Author?>> GetAllAuthorsAsync()
    {
        return await context.Authors.ToListAsync();
    }
}