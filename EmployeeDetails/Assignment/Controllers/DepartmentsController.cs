using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Controllers
{
    public class DepartmentsController:Controller
    {
        public string List()
        {
            return "From List() method";
        }
        public string Details()
        {
            return "From Details() method";
        }
    }
}
