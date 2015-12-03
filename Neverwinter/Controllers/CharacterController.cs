using System.Web.Mvc;

namespace Neverwinter.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Add()
        {
            // If user is logged in
            return View();

            // If user is NOT logged in
            // return View(Home/Index)
            // Including error Message
        }
    }
}