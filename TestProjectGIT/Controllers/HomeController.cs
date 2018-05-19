using System.Web.Mvc;

namespace TestProjectGIT.Controllers
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
            //this is a test
            //this is a new test
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AliWasHereBusGit()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AliWasHereOfficeGit()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}