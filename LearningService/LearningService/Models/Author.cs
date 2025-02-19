using System.ComponentModel.DataAnnotations.Schema;

namespace LearningService.Models;

public class Author
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")] 
    public string? Name { get; set; }
    
}