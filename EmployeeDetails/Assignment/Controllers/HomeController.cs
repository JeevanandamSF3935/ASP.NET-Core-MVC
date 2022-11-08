using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Models;
using Employees.ViewModels;

namespace Employees.Controllers
{
    public class HomeController:Controller
    {
        private readonly IEmployeeRepositary _employeeRepositary;
        public HomeController(IEmployeeRepositary employeeRepositary)
        {
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
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepositary.GetEmployee(id),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ActionResult Register()
        {
            ViewData["Title"] = "Register";
            return View();
        }
   

        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepositary.AddEmployee(employee);
                return RedirectToAction("Details", new { @id = newEmployee.Id });
            }
            return View();
        }
        public IActionResult Edit(Employee employee)
        {
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee,int Id)
        {
            _employeeRepositary.EditEmployee(employee);
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = employee,
                PageTitle = "Edited Details"
            };
            return RedirectToAction("Details", new { @id = homeDetailsViewModel.Employee.Id });
        }
        public IActionResult Delete(int Id)
        {
            Employee employee = _employeeRepositary.GetAllEmployees().FirstOrDefault(s => s.Id.Equals(Id));
            _employeeRepositary.DeleteEmployee(employee);
            return RedirectToAction("ViewDetails", "Home");
        }
    }
}
