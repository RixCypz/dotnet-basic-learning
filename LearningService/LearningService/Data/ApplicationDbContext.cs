using Microsoft.EntityFrameworkCore;
using LearningService.Models;

namespace LearningService.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().ToTable("books", schema: "learning");
        modelBuilder.Entity<Author>().ToTable("authors", schema: "learning");
    }
}