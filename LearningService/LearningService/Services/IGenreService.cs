using LearningService.Models.Entities;

namespace LearningService.Services;

public interface IGenreService
{
    Task<Genre?> GetGenreByCodeAsync(string code);
}