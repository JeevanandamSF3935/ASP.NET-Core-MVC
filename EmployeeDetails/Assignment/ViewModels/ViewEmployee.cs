using Employees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.ViewModels
{
    public class ViewEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DepartmentSet DepartmentName { get; set; }
        public string Home { get; set; }
        public string MailId { get; set; }
        public string PhoneNumber { get; set; }
        public string? Image { get; set; }
    }
}
