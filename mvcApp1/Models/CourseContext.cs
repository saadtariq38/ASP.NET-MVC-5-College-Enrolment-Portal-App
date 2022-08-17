using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvcApp1.Models
{
    public class CourseContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<User> Users { get; set; } 

        public DbSet<Contact> Contacts { get; set; }
       
    }
}