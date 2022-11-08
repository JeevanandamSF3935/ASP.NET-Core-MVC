using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class Employee
    {
<<<<<<< HEAD
       
        public int Id { get; set; }
=======
        private static int s_id = 0;
        public int Id { get; }
>>>>>>> 6777718e6d03e3d7796d95775719de3e1a8bd87c
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
<<<<<<< HEAD
=======
        public Employee()
        {
            s_id++;
            Id = s_id;
        }
>>>>>>> 6777718e6d03e3d7796d95775719de3e1a8bd87c
    }
}
