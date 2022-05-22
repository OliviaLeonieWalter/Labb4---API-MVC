using Labb4.Models;
using Labb4.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Labb4.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult List()
        {
            var bookListViewModel = new BookListViewModel();
            bookListViewModel.Books = _bookRepository.GetAllBooks;
            return View(bookListViewModel);
        }
        public IActionResult Details(int id)
        {
            var bookViewModel = new BookListViewModel();
            bookViewModel.Book = _bookRepository.GetBookById(id);
            return View(bookViewModel);
        }
       

    }
}
