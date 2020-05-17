using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foody_.Controllers
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
        public ViewResult OurMenu()
        {
            return View("~/Views/Shared/OurMenu.cshtml");
        }
        public ViewResult blog_page()
        {
            return View("~/Views/Shared/blog_page.cshtml");
        }
        public ViewResult single_page()
        {
            return View("~/Views/Shared/single_page.cshtml");
        }
    }
}