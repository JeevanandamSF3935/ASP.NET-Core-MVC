using Employees.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Models
{
    public interface IEmployeeRepositary
    {
        Employee GetEmployee(int Id);
        Employee AddEmployee(HomeDetailsViewModel homeDetailsViewModel,string imageFileName);
        IEnumerable<Employee> GetAllEmployees();
        void DeleteEmployee(int employeeId);
        Employee EditEmployee(Employee employee, string imageFileName);
        IEnumerable<ViewEmployee> ViewEmployees();
        IEnumerable<Department> GetAllDepartments();
        IEnumerable<Employee> ViewDepartment(int departmentId);
        Department UpdateDepartment(Department department);
    }
}
