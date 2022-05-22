using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Labb4.Models
{
    public class CustomerRepository : ICustomerRepository   
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Customer> GetAllCustomers
        {
            get
            {
                return _context.Customers;
            }
                
        }

        public Customer AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;    
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges(); 
        }
        public List<Book> GetCustomersBorrowedBooks(int id)
        {
            var books = new List<Book>();
            var output = from jointable in _context.customer_Books
                         join book in _context.Books on jointable.BookId equals book.BookID
                         where jointable.CustomerId == id
                         select book;

            foreach(var book in output)
            {
                books.Add(book);    
            }
            return books;   
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public void UpdateCustomer(Customer updateCustomer)
        {
            var result = _context.Customers.FirstOrDefault(c => c.CustomerID == updateCustomer.CustomerID);
            if(result != null)
            {
                result.CustomerName = updateCustomer.CustomerName;
                result.CustomerEmail = updateCustomer.CustomerEmail;
                _context.SaveChanges();
;
            }
        }
    }
}
