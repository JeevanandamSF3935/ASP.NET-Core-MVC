using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class Employee
    {
        private static int s_id = 0;
        public int Id { get; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Home { get; set; }
        [Required]
        [StringLength(20)]
        public string MailId { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        public Employee()
        {
            s_id++;
            Id = s_id;
        }
    }
}
