using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace mvcApp1.Models
{
    public class Teacher
    {
        
        public int TeacherId { get; set; }

        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        [Display(Name = "Course")]
        public String CourseTaught { get; set; }
    }
}