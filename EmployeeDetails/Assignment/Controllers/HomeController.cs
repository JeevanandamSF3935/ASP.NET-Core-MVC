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
<<<<<<< HEAD
   
=======
        [HttpPut]
        public ActionResult Register(HomeDetailsViewModel homeDetailsViewModel)
        {
            return RedirectToAction("Details", new { @id = homeDetailsViewModel.Employee.Id });
        }
>>>>>>> 6777718e6d03e3d7796d95775719de3e1a8bd87c

        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
=======
                HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
                {
                    Employee = employee,
                    PageTitle = "Employee Details"
                };
>>>>>>> 6777718e6d03e3d7796d95775719de3e1a8bd87c
                Employee newEmployee = _employeeRepositary.AddEmployee(employee);
                return RedirectToAction("Details", new { @id = newEmployee.Id });
            }
            return View();
        }
<<<<<<< HEAD
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
=======
        public IActionResult Edit(HomeDetailsViewModel homeDetailsViewModel)
        {
            return RedirectToAction("Register",homeDetailsViewModel);
        }
        public IActionResult Delete(Employee employee)
        {
            _employeeRepositary.DeleteEmploye(employee.Id);
            return RedirectToAction("Index", "Home");
>>>>>>> 6777718e6d03e3d7796d95775719de3e1a8bd87c
        }
    }
}
