using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Labb4.Models
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAllCustomers { get; }

        public Customer GetCustomerById(int id);

        public Customer AddCustomer(Customer customer);

        public void DeleteCustomer(Customer customer);

        public void UpdateCustomer(Customer updateCustomer);
        
        public List<Book> GetCustomersBorrowedBooks(int id);

    }
}
