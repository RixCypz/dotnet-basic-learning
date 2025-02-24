using LearningService.Models.Entities;

namespace LearningService.Services;

public interface IGenreService
{
    Task<Genre?> GetGenreByCodeAsync(string code);
    Task<IEnumerable<Genre>> GetAllGenres(int page, int pageSize);
}