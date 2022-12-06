using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage ="Book Name is required")]
        public string BookName { get; set; }
        public string? AuthorName { get; set; }
        public int? PublishYear { get; set; }
        public double? Price { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Select Valid Category")]
        public int BookCategoryId { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
