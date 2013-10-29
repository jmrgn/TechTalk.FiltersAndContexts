using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechTalk.FiltersAndContexts.Controllers
{
    // What if I want to control the order?
    [HandleErrorWrapperAttribute, LoggingFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            
            return View();
        }

        public ActionResult Error()
        {
            throw new Exception("Thrown!");
        }

        public ActionResult RecoverableError()
        {
            throw new CustomException("Recoverable Error Thrown!");
        }

        [OutputCache(Duration = 20, VaryByParam = "None")]
        public ActionResult OutputCache()
        {
            return View();
        }

        [AuthByName]
        public ActionResult About()
        {
            return View();
        }
    }
}
