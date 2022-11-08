using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public interface IEmployeeRepositary
    {
        Employee GetEmployee(int Id);
        Employee AddEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployees();
        void DeleteEmployee(Employee employee);
        Employee EditEmployee(Employee employee);
    }
}
