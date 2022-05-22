using Labb4.Models;
using Labb4.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IActionResult List()
        {
            var customerListModel = new CustomerListViewModel();
            customerListModel.Customers = _customerRepository.GetAllCustomers;
            if(customerListModel == null)
            {
                return NotFound();  
            }
            return View(customerListModel); 

        }
        public IActionResult BorrowedBookDetails(int id)
        {
            var borrowedBookList = new BorrowedBookViewModel();
            borrowedBookList.Customer = _customerRepository.GetCustomerById(id);
            borrowedBookList.BorrowedBooks = _customerRepository.GetCustomersBorrowedBooks(id);
            if(borrowedBookList == null)
            {
                return NotFound();
            }
            return View(borrowedBookList);
        }

        //Create New Customer
        public IActionResult Create()
        {
            var newCustomerVm = new CustomerViewModel();
            return View(newCustomerVm);
        }
        public IActionResult CreateCustomer(CustomerViewModel newCustomerVm)
        {
            _customerRepository.AddCustomer(newCustomerVm.NewCustomer);
            return RedirectToAction(nameof(List));
        }

        //Delete Customer
        public IActionResult Delete()
        {
            var newCustomerVm = new CustomerViewModel();
            newCustomerVm.Customers = _customerRepository.GetAllCustomers;
            return View(newCustomerVm);
        }
        public IActionResult DeleteCustomer(CustomerViewModel deleteCustomerVm)
        {
            var Customers = _customerRepository.GetAllCustomers;
            _customerRepository.DeleteCustomer(Customers.FirstOrDefault(c => c.CustomerName == deleteCustomerVm.NewCustomer.CustomerName));
            return RedirectToAction(nameof(List));
        }
        //Update Customer 
        public IActionResult Update()
        {
            var newCustomerVm = new CustomerViewModel();
            newCustomerVm.Customers = _customerRepository.GetAllCustomers;
            return View(newCustomerVm);
        }
        public IActionResult UpdateCustomer(CustomerViewModel updateCustomerVm)
        {
            _customerRepository.UpdateCustomer(updateCustomerVm.NewCustomer);
            return RedirectToAction(nameof(List));
        }
      
    }
}
