using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    public class HomeController:Controller
    {
        private IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepositary)
        {
            _bookRepository = bookRepositary;
        }
        public IActionResult Index()
        {
            var model = _bookRepository.GetAllBooks();
            IndexViewModel indexView = new IndexViewModel()
            {
                Books=model
            };
            return View(indexView);
        }
        [HttpPost]
        public IActionResult Index(IndexViewModel indexView)
        {
            if (indexView.SearchString != null)
            {
                var model = _bookRepository.GetAllBooks().Where(x => x.BookName.ToLower().Contains(indexView.SearchString.ToLower()));
                indexView.Books = model;
                return View(indexView);
            }
            else
            {
                var model = _bookRepository.GetAllBooks();
                indexView.Books = model;
                return View(indexView);
            }
        }
        public IActionResult ViewBook(Books book)
        {
            BookViewModel bookView = _bookRepository.ViewBook(book);
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
                return RedirectToAction("ViewBook",book);
            }
            return View();
        }

        public IActionResult EditBook(int bookId)
        {
            var book = _bookRepository.GetBook(bookId);
            return View(book);
        }
        [HttpPost]
        public IActionResult EditBook(Books book)
        {
            if (ModelState.IsValid)
            {
                book.UpdatedOn = DateTime.Now;
                _bookRepository.EditBook(book);
                return RedirectToAction("ViewBook", book);
            }
            return View(book);
        }

        public IActionResult DeleteBook(int bookId)
        {
            _bookRepository.DeleteBook(bookId);
            return RedirectToAction("Index");
        }
    }
}
