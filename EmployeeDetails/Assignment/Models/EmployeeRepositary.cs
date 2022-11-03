using System.Collections.Generic;
using System.Linq;

namespace Employees.Models
{
    public class EmployeeRepositary : IEmployeeRepositary
    {
        private List<Employee> _employeesList = new List<Employee>();

        public EmployeeRepositary()
        {
            _employeesList.Add(new Employee() { Name = "Jeeva", Home = "Hosur" ,MailId="jeeva@gmail.com",PhoneNumber="8526764646"});
            _employeesList.Add(new Employee() { Name = "Vikram", Home = "Chennai",MailId="vikram@hotmail.com",PhoneNumber="8220417431" });
            _employeesList.Add(new Employee() { Name = "Samiulla", Home = "Rayakottai",MailId="sam@yahoo.com",PhoneNumber="8976567867" });
        }
        public Employee AddEmployee(Employee employee)
        {
            _employeesList.Add(employee);
            return employee;
        }

        public void DeleteEmploye(int Id)
        {
            Employee employee = _employeesList.Where(s=>s.Id.Equals(Id)).Select(s=>s);
            _employeesList.Remove(employee);
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
