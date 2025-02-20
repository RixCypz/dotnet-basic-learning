using LearningService.Models.Entities;

namespace LearningService.Repositories;

public interface IGenreRepository
{
    Task<Genre?> GetGenreByCodeAsync(string code);
}