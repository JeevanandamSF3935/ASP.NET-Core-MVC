using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public enum DepartmentSet
    {
        Default,
        IT,
        Security,
        Developer
    }
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int EmployeeCount { get; set; }
    }
}
