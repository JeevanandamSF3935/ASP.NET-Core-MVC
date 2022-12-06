using LibraryManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public interface IBookRepository
    {
        IEnumerable<Books> GetAllBooks();
        Books GetBook(int bookId);
        Books AddBook(Books book);
        BookCategories GetCategory(int categoryId);
        BookViewModel ViewBook(Books book);
        Books EditBook(Books book);
        void DeleteBook(int bookId);
    }
}
