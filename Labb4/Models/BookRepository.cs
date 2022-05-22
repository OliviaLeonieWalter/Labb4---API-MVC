using System.Collections.Generic;
using System.Linq;
namespace Labb4.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IEnumerable<Book> GetAllBooks
        {
            get
            {
                return _context.Books;
            }
        }
        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.BookID == id);
        }
    }
}
