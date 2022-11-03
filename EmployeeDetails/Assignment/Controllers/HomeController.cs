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
            return View();
        }
        [HttpPut]
        public ActionResult Register(HomeDetailsViewModel homeDetailsViewModel)
        {
            return RedirectToAction("Details", new { @id = homeDetailsViewModel.Employee.Id });
        }

        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {
                HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
                {
                    Employee = employee,
                    PageTitle = "Employee Details"
                };
                Employee newEmployee = _employeeRepositary.AddEmployee(employee);
                return RedirectToAction("Details", new { @id = newEmployee.Id });
            }
            return View();
        }
        public IActionResult Edit(HomeDetailsViewModel homeDetailsViewModel)
        {
            return RedirectToAction("Register",homeDetailsViewModel);
        }
        public IActionResult Delete(Employee employee)
        {
            _employeeRepositary.DeleteEmploye(employee.Id);
            return RedirectToAction("Index", "Home");
        }
    }
}
