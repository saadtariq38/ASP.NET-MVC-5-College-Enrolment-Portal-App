using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcApp1.Models;
using mvcApp1.ViewModels;

namespace mvcApp1.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult GetCourses()
        {
            var courses = new List<Course>()
            {
                new Course() {Id = 1, Name = "Linear Algebra", CreditHours = 3},
                new Course() {Id = 2, Name = "Statistics",CreditHours = 3},
                new Course() {Id = 3, Name = "Intro to programming", CreditHours = 4},
                new Course() {Id = 4, Name = "Networking",  CreditHours = 4 }
            };

            return View(courses);
        }

        // GET: Course/GetEnrolled

        public ActionResult GetEnrolled()
        {
            var student= new User() {userId = 5, firstName = "omer", lastName = "khalid", age = 19};
           var courses = new List<Course>()
            {
                new Course() {Id = 2, Name = "Statistics", CreditHours = 3},
                new Course() {Id = 3, Name = "Intro to programming", CreditHours = 4}
            };

            var enrolledStudent = new EnrolledViewModel() { Student = student, Courses = courses };

            return View(enrolledStudent);
        }

        
    }
}