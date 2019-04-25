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
            IEnumerable<Phone> Phones = PhoneContext.Phones;

            ViewBag.Phones = Phones;

            return View();
        }

        public ActionResult PurchaseList()
        {
            IEnumerable<Purchase> Purchases = PhoneContext.Purchases;

            ViewBag.Purchases = Purchases;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int Id)
        {
            ViewBag.Id = Id;

            return View();
        }

        [HttpPost]
        public ActionResult Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;

            PhoneContext.Purchases.Add(purchase);

            PhoneContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}