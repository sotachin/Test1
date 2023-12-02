using System.Web.Mvc;

namespace test2301.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult show()
        {
            return File(Server.MapPath("~/Content/test.txt"), "text/plain");
        }
        public FileResult Download()
        {
            return File(Server.MapPath("~/Content/test.txt"), "text/plain", "myfile.text");
        }
        public RedirectResult ShowInternal()
        {
            return Redirect("/Home/ShowInfo");
        }
        public RedirectResult ShowExternal()
        {
            return Redirect("https://google.com");
        }
    }
}