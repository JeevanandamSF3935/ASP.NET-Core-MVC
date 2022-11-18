using System.Collections.Generic;

namespace Employees.Models
{
    public class DbEmployeeRepositary : IEmployeeRepositary
    {
        private readonly EmployeeDbContext _context;

        public DbEmployeeRepositary(EmployeeDbContext context)
        {
            this._context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public Employee EditEmployee(Employee employeeChanges)
        {
            var employee = _context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            return _context.Employees.Find(Id);
        }


        public IEnumerable<Department> GetAllDepartments()
        {
            return _context.departments;
        }
    }
}
