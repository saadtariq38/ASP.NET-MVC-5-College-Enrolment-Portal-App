using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcApp1.Models;

namespace mvcApp1.Controllers
{
    
    public class TeacherController : Controller
    {

        private CourseContext _context;

        public TeacherController()
        {
            _context = new CourseContext();
        }

        //GET: Teacher
        public ActionResult Index()
        {
            var teachers = _context.Teachers.ToList();
            return View(teachers);
        }

        public ActionResult Create()
        {
            return View(new Teacher { TeacherId = 0 });
        }

        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", teacher);
            }

            if(teacher.TeacherId > 0)
            {
                _context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
            } else
            {
                _context.Teachers.Add(teacher);
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var teacher = _context.Teachers.SingleOrDefault(x => x.TeacherId == id);

            if(teacher == null)
            {
                return HttpNotFound();
            }

            _context.Teachers.Remove(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var _teacher = _context.Teachers.SingleOrDefault(x => x.TeacherId == id);

            if(_teacher == null)
            {
                return HttpNotFound();
            }

            return View("Create", _teacher);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}