using Labb4.Models;
using System.Collections.Generic;

namespace Labb4.ViewModels
{
    public class BorrowBookViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }

        public Book BorrowBook { get; set; }

        public Customer_Book CustomerBookTable { get; set; }

    }
}
