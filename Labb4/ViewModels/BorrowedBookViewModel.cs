using Labb4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Labb4.ViewModels
{
    public class BorrowedBookViewModel
    {
        public Customer Customer { get; set; }
        public List<Book>BorrowedBooks { get; set; }
        public Customer_Book CustomerBookTable { get; set; }

    }
}
