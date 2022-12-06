using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.ViewModels
{
    public class BookViewModel
    {
        public Books Book { get; set; }
        public BookCategories BookCategory { get; set; }
    }
}
