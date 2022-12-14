using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.ViewModels
{
    public class IndexViewModel
    {
        public string? SearchString { get; set; }
        public IEnumerable<Books> Books { get; set; }
    }
}
