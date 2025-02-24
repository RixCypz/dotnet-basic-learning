using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningService.Models.Entities;

public class Genre
{
    [Key]
    [Column("code")]
    public string Code { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("created_date")]
    public DateTime CreatedDate { get; set; }
    
}