using System.Collections.Generic;
using System.Linq;

namespace Employees.Models
{
    public class EmployeeRepositary : IEmployeeRepositary
    {
        private List<Employee> _employeesList = new List<Employee>();

        public EmployeeRepositary()
        {
            _employeesList.Add(new Employee() { Name = "Jeeva", Home = "Hosur" });
            _employeesList.Add(new Employee() { Name = "Vikram", Home = "Chennai" });
            _employeesList.Add(new Employee() { Name = "Samiulla", Home = "Rayakottai" });
        }
        public Employee AddEmployee(Employee employee)
        {
            _employeesList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeesList.FirstOrDefault(s => s.Id.Equals(Id));
        }
    }
}
