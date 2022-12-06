using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
