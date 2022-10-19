using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodMonkeyCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult ContactUs()
        {
            ViewBag.Message = "Contact Us page";

            return View();
        }

        public ActionResult Cart()
        {

            return View();
        }
        public ActionResult UserLogin()
        {

            return View();
        }
    }
}