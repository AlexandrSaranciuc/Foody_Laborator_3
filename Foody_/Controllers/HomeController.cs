using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Foody_.Models;


namespace Foody_.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            return View(db.Books);
        }
       
        public ActionResult Create()
        {
            return View();
        }
      
        public ActionResult Create(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
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