using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvcApp1.Models
{
    public class Course
    {
        
        public int Id { get; set; }

        [Display(Name="Course Name")]
        [Required(ErrorMessage = "Course name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Credit Hours")]
        [Required(ErrorMessage = "Credit Hours are required")]
        public int CreditHours { get; set; }

        //Foreign Key
        [Display(Name = "Teacher ID")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}