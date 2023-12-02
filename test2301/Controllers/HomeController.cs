using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test2301.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = "Show you home Page";
            return View();
        }
        //diff name
        [ActionName("Info")]
        public ActionResult ShowInfo()

        {
            return View("Show");
        }
        [NonAction]
        public ActionResult Detail()
        {
            return View("Details");
        }
        [HttpPost]
        public ActionResult ShowMoreDetail()
        {
            return View("~/Views/About/MyProfile.cshtml");
        }
    }
}