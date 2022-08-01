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

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Credit Hours are required")]
        public int CreditHours { get; set; }    
    }
}