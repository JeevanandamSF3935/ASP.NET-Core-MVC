using LibraryManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public Books GetBook(int id)
        {
            Books book = _context.Books.FirstOrDefault(x => x.BookId.Equals(id));
            return book;
        }

        public Books AddBook(Books book)
        {
            book.UpdatedOn = DateTime.Now;
            var books = GetAllBooks().Where(x => x.BookName.Equals(book.BookName));
            if (books.Count()==0)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }
            else
            {
                book = null;
            }
            return book;
        }

        public IEnumerable<BookCategories> GetAllCategories()
        {
            return _context.BookCategories;
        }
        public BookCategories GetCategory(int categoryId)
        {
            BookCategories bookCategory = _context.BookCategories.FirstOrDefault(x => x.CategoryId.Equals(categoryId));
            return bookCategory;
        }

        public BookViewModel ViewBook(int id)
        {
            BookViewModel bookView = null;
            var book = GetBook(id);
            if (book != null)
            {
                BookCategories category = GetCategory(book.BookCategoryId);
                bookView = new BookViewModel()
                {
                    Book = book,
                    BookCategory = category
                };
            }
            return bookView;
        }

        public Books EditBook(Books book)
        {
            var newBook = new Books();
            var books = GetAllBooks().Where(x => x.BookName.Equals(book.BookName)&x.BookId!=book.BookId);
            if (books.Count() == 0)
            {
                newBook = _context.Books.Find(book.BookId);
                newBook.AuthorName = book.AuthorName;
                newBook.BookCategoryId = book.BookCategoryId;
                newBook.BookName = book.BookName;
                newBook.IsDeleted = book.IsDeleted;
                newBook.Price = book.Price;
                newBook.PublishYear = book.PublishYear;
                newBook.UpdatedOn = book.UpdatedOn;
                _context.SaveChanges();
            }
            else
            {
                newBook = null;
            }
            
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
