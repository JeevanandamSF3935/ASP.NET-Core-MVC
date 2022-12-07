using System;
using System.ComponentModel.DataAnnotations;
namespace LibraryManagement.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage ="Book Name is required")]
        public string BookName { get; set; }
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage = "Author Name Should be alphabets")]
        public string? AuthorName { get; set; }
        [Display(Name ="Year")]
        [RegularExpression("^[0-9]*$",ErrorMessage = "Year should be only numericals")]
        [Range(1,2022,ErrorMessage = "Enter valid year upto present year")]
        public int? PublishYear { get; set; }
        [RegularExpression("^[0-9]*$",ErrorMessage="Price should be only numericals")]
        public double? Price { get; set; }
        [RegularExpression("^[1-6]*$",ErrorMessage ="Select Valid Category")]
        public int BookCategoryId { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
