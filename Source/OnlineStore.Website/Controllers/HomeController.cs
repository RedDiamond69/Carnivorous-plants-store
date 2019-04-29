using OnlineStore.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Catalog()
        {
            return View();
        }

        public ActionResult PaymentAndDelivery()
        {
            return View();
        }

        public ActionResult Stock()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }
    }
}