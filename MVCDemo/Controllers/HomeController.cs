using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    //ContentResult contentResult = new ContentResult();
        //    //contentResult.Content = "hello from content rrsult";
        //    //return contentResult;

        //    return Content("hello from content rrsult");
        //}

        //public ActionResult AboutUs()
        //{
        //    return Redirect("https://drive.google.com/drive/folders/18B9-kvGFWuqql0Ai_iRunjecAYvr4F-G");

        //    //return RedirectToAction("Index");
        //}

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }
    }
}
