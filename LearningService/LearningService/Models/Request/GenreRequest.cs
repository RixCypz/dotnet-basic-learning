using System.ComponentModel.DataAnnotations;

namespace LearningService.Models.Request;

public class GenreRequest
{
    [Required(ErrorMessage = "Genre code is required.")]
    public string Code { get; set; }
}