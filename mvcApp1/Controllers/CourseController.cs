using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcApp1.Models;
using mvcApp1.ViewModels;
using System.Data.Entity;

namespace mvcApp1.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course

        private CourseContext _context;
        public CourseController()
        {
            _context = new CourseContext();
        }
        public ActionResult GetCourses()
        {
            //Eager loading
            var courses = _context.Courses.Include(t => t.Teacher).ToList();

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

        public ActionResult Create()
        {
            var teachers = _context.Teachers.ToList();

            var viewModel = new CourseTeacherViewModel
            {
                Course = new Course(),
                Teachers = teachers
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();

            return Content("Course registered successfully");
        }
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                _context.Dispose();
            }   
            base.Dispose(disposing);
        }

        
    }
}