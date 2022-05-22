using Labb4.Models;
using System.Collections.Generic;
using System.Linq;
namespace Labb4.ViewModels
{
    public class CustomerListViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}

