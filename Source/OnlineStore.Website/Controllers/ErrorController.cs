using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Website.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet]
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            ViewBag.Title = Resources.Resource.NotFoundTitle;
            ViewBag.Message = Resources.Resource.NotFoundMessage;
            ViewBag.Favicon = Url.Content("~/Content/Images/Website/error.png");
            ViewBag.Image = Url.Content("~/Content/Images/Website/404.svg");
            return View("Index");
        }

        [HttpGet]
        public ActionResult InternalServerError()
        {
            Response.StatusCode = 500;
            ViewBag.Title = Resources.Resource.InternalServerErrorTitle;
            ViewBag.Message = Resources.Resource.InternalServerErrorMessage;
            ViewBag.Favicon = Url.Content("~/Content/Images/Website/error.png");
            ViewBag.Image = Url.Content("~/Content/Images/Website/500.svg");
            return View("Index");
        }
    }
}