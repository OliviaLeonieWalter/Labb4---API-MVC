using Labb4.Models;
using System.Collections.Generic;
using System.Linq;
namespace Labb4.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }

        public Book Book { get; set; }
    }
}
