using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Neverwinter.Controllers
{
    public class HomeController : Controller
    {
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

    }
}