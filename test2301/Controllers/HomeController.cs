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
        public ActionResult ShowInfo()
        {
            return View("Show");
        }
        public ActionResult Detail()
        {
            return View("Details");
        }
        public ActionResult ShowMoreDetail()
        {
            return View("~/Views/About/MyProfile.cshtml");
        }
    }
}