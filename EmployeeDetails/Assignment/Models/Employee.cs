using System.ComponentModel.DataAnnotations;
namespace Employees.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public DepartmentSet ? department { get; set; }
        [Required]
        [StringLength(10)]
        public string Home { get; set; }
        [Required]
        [StringLength(50)]
        public string MailId { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        public string ? ProfileImage { get; set; }
    }
}
