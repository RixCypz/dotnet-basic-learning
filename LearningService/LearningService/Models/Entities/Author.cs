using System.ComponentModel.DataAnnotations.Schema;

namespace LearningService.Models.Entities;

public class Author
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")] 
    public string? Name { get; set; }
    
}