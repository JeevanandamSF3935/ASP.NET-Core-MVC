using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepositary)
        {
            _bookRepository = bookRepositary;
        }
        public IActionResult Index()
        {
            var model = _bookRepository.GetAllBooks().OrderBy(x => x.BookId);
            IndexViewModel indexView = new IndexViewModel()
            {
                Books = model
            };
            return View(indexView);
        }
        [HttpPost]
        public IActionResult Index(IndexViewModel indexView)
        {
            if (indexView.SearchString != null)
            {
                var model = _bookRepository.GetAllBooks().Where(x => x.BookName.ToLower().Contains(indexView.SearchString.ToLower())).OrderBy(x => x.BookId);
                indexView.Books = model;
                return View(indexView);
            }
            else
            {
                var model = _bookRepository.GetAllBooks().OrderBy(x=>x.BookId);
                indexView.Books = model;
                return View(indexView);
            }
        }
        [Route("book/{id}")]
        public IActionResult ViewBook(int id)
        {
            BookViewModel bookView = _bookRepository.ViewBook(id);
            if (bookView == null || bookView.Book.IsDeleted==true) { ViewBag.Message = "No book found for given ID"; }
            return View(bookView);
        }
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Books book)
        {
            if (ModelState.IsValid)
            {
                Books newBook = _bookRepository.AddBook(book);
                if (newBook != null)
                {
                    return RedirectToAction("ViewBook", new { @id= newBook.BookId });
                }
                else
                {
                    ViewBag.Message = "Book Name already exists";
                }
            }
            return View();
        }

        public IActionResult EditBook(int id)
        {
            var book = _bookRepository.GetBook(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult EditBook(Books book)
        {
            if (ModelState.IsValid)
            {
                book.UpdatedOn = DateTime.Now;
                var newBook = _bookRepository.EditBook(book);
                if (newBook != null)
                {
                    return RedirectToAction("ViewBook", new { @id = newBook.BookId });
                }
                else
                {
                    ViewBag.Message = "Book Name already exists";
                }
            }
            return View(book);
        }

        public IActionResult DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
            return RedirectToAction("Index");
        }
    }
}
