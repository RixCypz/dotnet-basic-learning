using Microsoft.EntityFrameworkCore;
using LearningService.Models.Entities;

namespace LearningService.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre?> Genres { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().ToTable("books", schema: "learning");
        modelBuilder.Entity<Author>().ToTable("authors", schema: "learning");
        modelBuilder.Entity<Genre>().ToTable("genres", schema: "learning");
    }
}