using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class BookCategories
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public DateTime UpdatedOn { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
