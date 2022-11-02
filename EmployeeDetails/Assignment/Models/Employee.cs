using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class Employee
    {
        private static int s_id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Home { get; set; }
        public Employee()
        {
            s_id++;
            Id = s_id;
        }
    }
}
