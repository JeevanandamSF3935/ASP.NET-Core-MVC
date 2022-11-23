using Employees.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Employees.ViewModels
{
    public class HomeDetailsViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public DepartmentSet? department { get; set; }
        [Required]
        [StringLength(10)]
        public string Home { get; set; }
        [Required]
        [StringLength(50)]
        public string MailId { get; set; }
        [Required]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public IFormFile ProfileImage { get; set; }
    }
}
