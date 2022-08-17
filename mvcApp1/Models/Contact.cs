using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace mvcApp1.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Your name is required")]

        public String Name { get; set; }

        [Required(ErrorMessage = "Your email is required")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required(ErrorMessage = "Your phone number is required")]
        [DataType(DataType.PhoneNumber)]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Please provide a valid query")]
        public String Query { get; set; }

    }
}