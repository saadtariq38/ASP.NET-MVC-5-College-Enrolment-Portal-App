using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcApp1.Models;

namespace mvcApp1.ViewModels
{
    public class EnrolledViewModel
    {
        public User Student { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}