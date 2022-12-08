using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class RangeUntilCurrentYear:RangeAttribute
    {
        public RangeUntilCurrentYear(int minimum):base(minimum,DateTime.Now.Year)
        {
        }
    }
}
