using Employees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.ViewModels
{
    public class ViewDepartments
    {
        public int NonDepartmentEmployeeCount { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Employee> EmployeesList { get; set; }
    }
}
