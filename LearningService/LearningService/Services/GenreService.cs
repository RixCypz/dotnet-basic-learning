using LearningService.Models.Entities;
using LearningService.Repositories;

namespace LearningService.Services;

public class GenreService(IGenreRepository genreRepository) : IGenreService
{
    public async Task<Genre?> GetGenreByCodeAsync(string code)
    {
        return await genreRepository.GetGenreByCodeAsync(code);
    }
}