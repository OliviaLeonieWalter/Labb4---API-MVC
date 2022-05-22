using Labb4.Models;
using System.Collections.Generic;

namespace Labb4.ViewModels
{
    public class CustomerViewModel
    {
        public Customer NewCustomer { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
