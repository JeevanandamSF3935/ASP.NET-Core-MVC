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
<<<<<<< HEAD
        void DeleteEmployee(Employee employee);
        Employee EditEmployee(Employee employee);
=======
        void DeleteEmploye(int Id);
>>>>>>> 6777718e6d03e3d7796d95775719de3e1a8bd87c
    }
}
