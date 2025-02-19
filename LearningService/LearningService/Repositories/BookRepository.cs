using LearningService.Data;
using LearningService.Models;

namespace LearningService.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

       public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);  
        }
    }
}
