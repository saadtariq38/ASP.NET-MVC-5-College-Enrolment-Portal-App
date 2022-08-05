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

        // GET: Course/GetCourses
        public ActionResult GetCourses()
        {
            //Eager loading
            var courses = _context.Courses.Include(t => t.Teacher).ToList();

            return View(courses);
        }

        // GET: Course/GetEnrolled

        /*
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

        */
        public ActionResult Create()
        {
            var teachers = _context.Teachers.ToList();
            Course course = new Course
            {
                Id = 0
            };

            var viewModel = new CourseTeacherViewModel
            {
                Course = course,
                Teachers = teachers
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(CourseTeacherViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", ViewModel.Course);
            }

            if (ViewModel.Course.Id > 0)
            {
                _context.Entry(ViewModel.Course).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _context.Courses.Add(ViewModel.Course);
            }

            
            _context.SaveChanges();
            return RedirectToAction("GetCourses");
        }

        /*
         * 
        [HttpPost]
        public ActionResult EditCourse(Course course)
        {

            _context.Entry(course).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("GetCourses");
        }

        */

        

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            
            var course = _context.Courses.SingleOrDefault(x => x.Id == id);

            if(course == null)
            {
                return HttpNotFound();
            }

            var ViewModel = new CourseTeacherViewModel
            {
                Course = course,
                Teachers = _context.Teachers.ToList()
            };

            return View("Create", ViewModel);
            
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var course = _context.Courses.SingleOrDefault(x => x.Id == id);

            if (course == null)
            {
                return HttpNotFound();
            }

            _context.Courses.Remove(course);
            _context.SaveChanges();

            return RedirectToAction("GetCourses");
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