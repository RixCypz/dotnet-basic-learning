using LearningService.Data;
using LearningService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningService.Repositories;

public class GenreRepository(ApplicationDbContext context) : IGenreRepository
{
    public async Task<Genre?> GetGenreByCodeAsync(string code)
    {
        return await context.Genres.Where(g => g.Code == code).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Genre>> GetAllGenres(int page, int pageSize)
    {
        return await context.Genres.OrderBy(g => g.Code).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
    }
}