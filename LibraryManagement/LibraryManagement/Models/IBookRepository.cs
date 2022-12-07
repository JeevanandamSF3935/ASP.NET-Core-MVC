using LibraryManagement.ViewModels;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public interface IBookRepository
    {
        IEnumerable<BookCategories> GetAllCategories();
        IEnumerable<Books> GetAllBooks();
        Books GetBook(int bookId);
        Books AddBook(Books book);
        BookCategories GetCategory(int categoryId);
        BookViewModel ViewBook(int id);
        Books EditBook(Books book);
        void DeleteBook(int bookId);
    }
}
