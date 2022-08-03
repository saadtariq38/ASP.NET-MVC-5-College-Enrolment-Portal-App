using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcApp1.Models;

namespace mvcApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //  Home/AboutUser

        /*
        public ActionResult AboutUser()
        {
           

            List<User> Users = new List<User>()
           {
               new User() {userId = 1,firstName = "Saad", lastName = "Tariq", age = 20},
               new User() {userId = 2,firstName = "Maaz", lastName = "Tariq", age = 20},
               new User() {userId = 3,firstName = "Zarish", lastName = "Khan", age = 21},
               new User() {userId = 4,firstName = "Mir", lastName = "Hamza", age = 20},

           };

            ViewBag.Users = Users;

            return View();
        }

        */

        [Route("Home/passingYear/{month:int:range(1,12)}/{year:int:min(1990)}")]
        public ActionResult ByPassingYear(int month, int year)
        {

            return Content("Month: " + month + " year: " + year);
        }


   
        public ActionResult AboutClubs()
        {
            var Clubs = new List<Club>()
            {
                new Club() {ClubId = 1, Name = "Technology Club", ChairName = "Saad Tariq", memberNum = 120},
                new Club() {ClubId = 2, Name = "Maths Club", ChairName = "Mir Hamza", memberNum = 38},
                new Club() {ClubId = 3, Name = "Sports Club", ChairName = "Omer Khalid", memberNum = 180},
                new Club() {ClubId = 4, Name = "Economics Club", ChairName = "Zarish Khan", memberNum = 59}
            };

            return View(Clubs);
        }

    }
}