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
<<<<<<< HEAD
            _employeesList.Add(new Employee() { Id=++s_id, Name = "Jeeva", Home = "Hosur" ,MailId="jeeva@gmail.com",PhoneNumber="8526764646"});
            _employeesList.Add(new Employee() { Id=++s_id, Name = "Vikram", Home = "Chennai",MailId="vikram@hotmail.com",PhoneNumber="8220417431" });
            _employeesList.Add(new Employee() { Id=++s_id, Name = "Samiulla", Home = "Rayakottai",MailId="sam@yahoo.com",PhoneNumber="8976567867" });
=======
            _employeesList.Add(new Employee() { Name = "Jeeva", Home = "Hosur" ,MailId="jeeva@gmail.com",PhoneNumber="8526764646"});
            _employeesList.Add(new Employee() { Name = "Vikram", Home = "Chennai",MailId="vikram@hotmail.com",PhoneNumber="8220417431" });
            _employeesList.Add(new Employee() { Name = "Samiulla", Home = "Rayakottai",MailId="sam@yahoo.com",PhoneNumber="8976567867" });
>>>>>>> 6777718e6d03e3d7796d95775719de3e1a8bd87c
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = ++s_id;
            _employeesList.Add(employee);
            return employee;
        }

<<<<<<< HEAD
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

=======
        public void DeleteEmploye(int Id)
        {
            Employee employee = _employeesList.Where(s=>s.Id.Equals(Id)).Select(s=>s);
            _employeesList.Remove(employee);
        }

>>>>>>> 6777718e6d03e3d7796d95775719de3e1a8bd87c
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
