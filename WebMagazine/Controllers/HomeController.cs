using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMagazine.Models;


namespace WebMagazine.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext PhoneContext = new PhoneContext();

        public ActionResult Index()
        {
            IEnumerable<Phone> phones = PhoneContext.Phones;

            ViewBag.Phones = phones;

            return View();
        }
    }
}