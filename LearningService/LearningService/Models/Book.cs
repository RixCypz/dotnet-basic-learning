using System.ComponentModel.DataAnnotations.Schema;

namespace LearningService.Models;

public class Book
{
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    public string? Title { get; set; }

    [Column("author")]
    public string? Author { get; set; }

    [Column("created_date")]
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}