using OnlineStore.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

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