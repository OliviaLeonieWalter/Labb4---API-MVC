using System.Collections.Generic;
namespace Labb4.Models
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetAllBooks { get; }

        public Book GetBookById(int id);
    }
}

