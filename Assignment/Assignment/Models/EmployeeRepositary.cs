using System.Collections.Generic;
using System.Linq;

namespace Employees.Models
{
    public class EmployeeRepositary : IEmployeeRepositary
    {
        private List<Employee> _employeesList;

        public EmployeeRepositary()
        {
            _employeesList = new List<Employee>()
            {
                new Employee(){Id = 1,Name="Jeeva",Home="Hosur"},
                new Employee(){Id = 2,Name="Vikram",Home="Chennai"},
                new Employee(){Id = 3,Name="Samiulla",Home="Rayakottai"}
            };
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
