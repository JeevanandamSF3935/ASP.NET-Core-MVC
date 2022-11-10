using Microsoft.AspNetCore.Mvc;

namespace Employees.Controllers
{
    public class DepartmentsController : Controller
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
