using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcApp1.Models
{
    public class User
    {
       
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
}