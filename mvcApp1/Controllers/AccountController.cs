using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcApp1.Models;
using mvcApp1.ViewModels;

namespace mvcApp1.Controllers
{
    public class AccountController : Controller
    {

        private CourseContext _context;

        public AccountController()
        {
            _context = new CourseContext(); 
        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if(!ModelState.IsValid)
            {
                return View("Register", user);
            }

            if(_context.Users.Where(u => u.Email == user.Email).Any())
            {
                ModelState.AddModelError("Email", "This email is already registered");
                return View("Register", user);
            }

            if(_context.Users.Where(u => u.UserName == user.UserName).Any())
            {
                ModelState.AddModelError("UserName", "This Username is taken. Please choose again.");
                return View("Register", user);
            }



            _context.Users.Add(user);
            _context.SaveChanges();

            return Content("User successfully registered");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginFormViewModel user)
        {
            if(!ModelState.IsValid)
            {
                return View("Login", user);
            }

            var loggedInUser = _context.Users.Where(u => u.UserName == user.UserName && u.Password == user.Password && u.IsActive == true).FirstOrDefault();

            if(loggedInUser == null)
            {
                ModelState.AddModelError("UserName", "Username or Password is incorrect, please try again");
                return View("Login", user);

            } else
            {
                Session["UserName"] = loggedInUser.UserName;
                return RedirectToAction("Index", "Home");
            }

           
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("login");
        }


    }
}