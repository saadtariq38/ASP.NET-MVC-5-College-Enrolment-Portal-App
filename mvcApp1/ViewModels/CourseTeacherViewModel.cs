using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcApp1.Models;

namespace mvcApp1.ViewModels
{
    public class CourseTeacherViewModel
    {
        
        public Course Course { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}