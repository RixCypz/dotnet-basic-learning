using LearningService.Data;
using LearningService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningService.Repositories;

public class GenreRepository(ApplicationDbContext context) : IGenreRepository
{
    public async Task<Genre?> GetGenreByCodeAsync(string code)
    {
        return await context.Genres
            .Where(g => g != null && g.Code == code)
            .FirstOrDefaultAsync();
    }
}