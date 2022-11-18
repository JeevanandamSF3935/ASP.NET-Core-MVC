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
        private readonly IEmployeeRepositary _employeeRepositary;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public HomeController(IEmployeeRepositary employeeRepositary,IWebHostEnvironment webHostEnvironment)
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
            var model = _employeeRepositary.GetAllEmployees();
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

        private string UploadedFile(HomeDetailsViewModel model)
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
                string uniqueFileName;
                if (homeDetailsViewModel.ProfileImage == null)
                {
                    uniqueFileName = "nouser.png";
                }
                else
                {
                    uniqueFileName = UploadedFile(homeDetailsViewModel);
                }
                Employee employee = new Employee()
                {
                    Id = homeDetailsViewModel.Id,
                    department=homeDetailsViewModel.department.Value,
                    Name = homeDetailsViewModel.Name,
                    Home = homeDetailsViewModel.Home,
                    MailId = homeDetailsViewModel.MailId,
                    PhoneNumber = homeDetailsViewModel.PhoneNumber,
                    ProfileImage = uniqueFileName
                };
                
                Employee newEmployee = _employeeRepositary.AddEmployee(employee);
                return RedirectToAction("Details", new { @id = newEmployee.Id });
            }
            return View();
        }
        public IActionResult Edit(Employee employee)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Id = employee.Id,
                Name = employee.Name,
                MailId = employee.MailId,
                PhoneNumber = employee.PhoneNumber,
                Home = employee.Home
            };
            return View(homeDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Edit(HomeDetailsViewModel homeDetailsViewModel, int Id)
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
                _employeeRepositary.EditEmployee(employee);

                return RedirectToAction("Details", new { @id = employee.Id });
            }
            return View();
        }
        public IActionResult Delete(int Id)
        {
            Employee employee = _employeeRepositary.GetAllEmployees().FirstOrDefault(s => s.Id.Equals(Id));
            _employeeRepositary.DeleteEmployee(employee);
            return RedirectToAction("ViewDetails");
        }

        public IActionResult ViewDepartments()
        {
            var model = _employeeRepositary.GetAllDepartments();
            return View(model);
        }

        public IActionResult ViewDepartment(Department department)
        {
            ViewBag.Title = department.Name.ToString();
            var model = _employeeRepositary.GetAllEmployees();
            IEnumerable<Employee> resultModel = model.Where(x => x.department.ToString().Equals(department.Name)).Select(x => x);
            return View(resultModel);
        }
    }
}
