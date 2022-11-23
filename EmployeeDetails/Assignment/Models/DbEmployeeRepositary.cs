using Employees.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Employees.Models
{
    public class DbEmployeeRepositary : IEmployeeRepositary
    {
        private readonly EmployeeDbContext _context;

        public DbEmployeeRepositary(EmployeeDbContext context)
        {
            this._context = context;
        }

        public Employee AddEmployee(HomeDetailsViewModel homeDetailsViewModel,string imageFileName)
        {

            Employee employee = new Employee()
            {
                Id = homeDetailsViewModel.Id,
                department = homeDetailsViewModel.department,
                Name = homeDetailsViewModel.Name,
                Home = homeDetailsViewModel.Home,
                MailId = homeDetailsViewModel.MailId,
                PhoneNumber = homeDetailsViewModel.PhoneNumber,
                ProfileImage = imageFileName
            };
            Department department = _context.departments.FirstOrDefault(x => x.Name.Equals(homeDetailsViewModel.department.ToString()));
            if (department != null)
            {
                department.EmployeeCount++;
                Department newDepartment = UpdateDepartment(department);
            }
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetAllEmployees().FirstOrDefault(s => s.Id.Equals(id));
            Department department = GetAllDepartments().FirstOrDefault(x => x.Name.Equals(employee.department.ToString()));
            department.EmployeeCount--;
            Department departmentUpdated = UpdateDepartment(department);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public Employee EditEmployee(Employee employeeChanges,string imageFileName)
        {
            if (employeeChanges.department.Value != default)
            {
                Department department = GetAllDepartments().FirstOrDefault(x => x.Name.Equals(employeeChanges.department.ToString()));
                department.EmployeeCount++;
                Department departmentUpdated = UpdateDepartment(department);
            }
            var employee = _context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees;
        }

        public IEnumerable<ViewEmployee> ViewEmployees()
        {
            var employeesList = (_context.Employees.GroupJoin(_context.departments,e=>(int)e.department,d=>d.Id,
                                (employee,department)=>new { employee,department}).
                                SelectMany(s=>s.department.DefaultIfEmpty(),
                                (e,d)=>new ViewEmployee
                                {
                                    Id=e.employee.Id,
                                    Name=e.employee.Name,
                                    Image=e.employee.ProfileImage,
                                    DepartmentName=e.employee.department.Value,
                                    Home=e.employee.Home,
                                    MailId = e.employee.MailId,
                                    PhoneNumber = e.employee.PhoneNumber
                                })
                                ).AsEnumerable();
            return employeesList;
        }

        public Employee GetEmployee(int Id)
        {
            return _context.Employees.Find(Id);
        }


        public IEnumerable<Department> GetAllDepartments()
        {
            return _context.departments;
        }

        public Department UpdateDepartment(Department departmentChanges) {
            var department = _context.departments.Attach(departmentChanges);
            department.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return departmentChanges;
        }

        public IEnumerable<Employee> ViewDepartment(int departmentId)
        {
            IEnumerable<Employee> selectedEmployees = null;
            var employees = GetAllEmployees(); ;
            if (departmentId == 0)
            { 
                selectedEmployees = employees.Where(x => x.department.Equals(null)).Select(x => x);
            }
            else
            {
                var department = GetAllDepartments().FirstOrDefault(x => x.Id == departmentId);
                selectedEmployees = employees.Where(x => x.department.ToString().Equals(department.Name)).Select(x => x);
            }
            return selectedEmployees;
        }

    }
}
