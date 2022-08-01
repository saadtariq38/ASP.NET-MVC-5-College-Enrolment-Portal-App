using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcApp1.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public String CourseTaught { get; set; }
    }
}