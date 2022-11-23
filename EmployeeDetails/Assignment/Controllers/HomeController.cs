using Employees.Models;
using Employees.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Employees.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepositary _employeeRepositary = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;
        public HomeController(IEmployeeRepositary employeeRepositary, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _employeeRepositary = employeeRepositary;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewDetails()
        {
            var model = _employeeRepositary.ViewEmployees();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            Employee employee = _employeeRepositary.GetEmployee(id);
            return View(employee);
        }
        public ActionResult Register()
        {
            ViewBag.Title = "Register";
            return View();
        }

        public string UploadedFile(HomeDetailsViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploadedImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                model.ProfileImage.CopyTo(fileStream);
            }

            return uniqueFileName;
        }

        [HttpPost]
        public IActionResult Register(HomeDetailsViewModel homeDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                string imageFileName;
                if (homeDetailsViewModel.ProfileImage == null)
                {
                    imageFileName = "nouser.png";
                }
                else
                {
                    imageFileName = UploadedFile(homeDetailsViewModel);
                }
                Employee newEmployee = _employeeRepositary.AddEmployee(homeDetailsViewModel,imageFileName);
                return RedirectToAction("Details", new { @id = newEmployee.Id });
            }
            return View();
        }
        public IActionResult Edit(HomeDetailsViewModel homeDetailsViewModel)
        {
            if (homeDetailsViewModel.department.Value != default) 
            {
                Department department = _employeeRepositary.GetAllDepartments().FirstOrDefault(x => x.Name.Equals(homeDetailsViewModel.department.ToString()));
                department.EmployeeCount--;
                Department departmentUpdated = _employeeRepositary.UpdateDepartment(department);
            }
            return View(homeDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Edit(HomeDetailsViewModel homeDetailsViewModel,int employeeId)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(homeDetailsViewModel);
                Employee employee = new Employee()
                {
                    Id = homeDetailsViewModel.Id,
                    department = homeDetailsViewModel.department.Value,
                    Name = homeDetailsViewModel.Name,
                    Home = homeDetailsViewModel.Home,
                    MailId = homeDetailsViewModel.MailId,
                    PhoneNumber = homeDetailsViewModel.PhoneNumber,
                    ProfileImage = uniqueFileName
                };
                _employeeRepositary.EditEmployee(employee,uniqueFileName);

                return RedirectToAction("Details", new { @id = employee.Id });
            }
            return View(homeDetailsViewModel);
        }
        public IActionResult Delete(int id)
        {
            _employeeRepositary.DeleteEmployee(id);
            return RedirectToAction("ViewDetails");
        }

        public IActionResult ViewDepartments()
        {
            var departments = _employeeRepositary.GetAllDepartments();
            var employees = _employeeRepositary.GetAllEmployees().Where(x => x.department.Equals(null)).Select(x => x);
            ViewDepartments view = new ViewDepartments()
            {
                Departments = departments,
                NonDepartmentEmployeeCount = employees.Count(),
                EmployeesList = employees
            };
            return View(view);
        }
        public IActionResult ViewDepartment(int departmentId)
        {
            var selectedEmployees = _employeeRepositary.ViewDepartment(departmentId);
            if (departmentId == 0)
            {
                ViewBag.Title = "Non-Department";
            }
            else
            {
                ViewBag.Title = selectedEmployees.First().department.Value;
            }
            return View(selectedEmployees);
        }
    }
}
