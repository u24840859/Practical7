using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INF272_Practical_06.Models;

namespace INF272_Practical_06.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Repository repository = new Repository();
            return View(repository.GetPublications());
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
    }
}