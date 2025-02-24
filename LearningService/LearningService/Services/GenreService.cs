using LearningService.Models.Entities;
using LearningService.Repositories;

namespace LearningService.Services;

public class GenreService(IGenreRepository genreRepository) : IGenreService
{
    public async Task<Genre?> GetGenreByCodeAsync(string code)
    {
        return await genreRepository.GetGenreByCodeAsync(code);
    }

    public async Task<IEnumerable<Genre>> GetAllGenres(int page, int pageSize)
    {
        return await genreRepository.GetAllGenres(page, pageSize);
    }
}