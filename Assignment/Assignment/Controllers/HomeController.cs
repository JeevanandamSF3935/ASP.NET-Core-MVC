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
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult ViewDetails()
        {
            var model = _employeeRepositary.GetAllEmployees();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            if (id == 0) return View("Views/Home/DetailsView.cshtml");
            else
            {
                HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
                {
                    Employee = _employeeRepositary.GetEmployee(id),
                    PageTitle = "Employee Details from ViewModels"
                };
                return View(homeDetailsViewModel);
            }
        }

    }
}
