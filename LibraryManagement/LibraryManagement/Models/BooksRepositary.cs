using LibraryManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class BooksRepositary : IBookRepository
    {
        private AppDbContext _context;

        public BooksRepositary(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Books> GetAllBooks()
        {
            return _context.Books;
        }

        public Books GetBook(int bookId)
        {
            Books book = _context.Books.FirstOrDefault(x => x.BookId.Equals(bookId));
            return book;
        }

        public Books AddBook(Books book)
        {
            book.UpdatedOn = DateTime.Now;
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public BookCategories GetCategory(int categoryId)
        {
            BookCategories bookCategory = _context.BookCategories.FirstOrDefault(x => x.CategoryId.Equals(categoryId));
            return bookCategory;
        }

        public BookViewModel ViewBook(Books book)
        {
            BookCategories category = GetCategory(book.BookCategoryId);
            BookViewModel bookView = new BookViewModel()
            {
                Book = book,
                BookCategory = category
            };
            return bookView;
        }

        public Books EditBook(Books book)
        {
            var newBook = _context.Books.Find(book.BookId);
            newBook.AuthorName = book.AuthorName;
            newBook.BookCategoryId = book.BookCategoryId;
            newBook.BookName = book.BookName;
            newBook.IsDeleted = book.IsDeleted;
            newBook.Price = book.Price;
            newBook.PublishYear = book.PublishYear;
            newBook.UpdatedOn = book.UpdatedOn;
            _context.SaveChanges();
            return newBook;
        }

        public void DeleteBook(int bookId)
        {
            var newBook = _context.Books.Find(bookId);
            newBook.IsDeleted = true;
            _context.SaveChanges();
        }
    }
}
