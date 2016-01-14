using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Neverwinter.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult DoLogin()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Short description of the Project:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Creators of the project:";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login page";
            return View();
        }

    }
}