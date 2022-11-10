using System.Collections.Generic;
using System.Linq;

namespace Employees.Models
{
    public class EmployeeRepositary : IEmployeeRepositary
    {
        private static int s_id = 0;
        private List<Employee> _employeesList = new List<Employee>();

        public EmployeeRepositary()
        {
            _employeesList.Add(new Employee() { Id = ++s_id, Name = "Jeeva", Home = "Hosur", MailId = "jeeva@gmail.com", PhoneNumber = "8526764646" });
            _employeesList.Add(new Employee() { Id = ++s_id, Name = "Vikram", Home = "Chennai", MailId = "vikram@hotmail.com", PhoneNumber = "8220417431" });
            _employeesList.Add(new Employee() { Id = ++s_id, Name = "Samiulla", Home = "Rayakottai", MailId = "sam@yahoo.com", PhoneNumber = "8976567867" });
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = ++s_id;
            _employeesList.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeesList.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            Employee editEmployee = _employeesList.FirstOrDefault(s => s.Id.Equals(employee.Id));
            _employeesList.Remove(editEmployee);
            _employeesList.Insert(employee.Id - 1, employee);
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
