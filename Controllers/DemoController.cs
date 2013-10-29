using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechTalk.FiltersAndContexts.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AuthorizationIndex()
        {
            string result = "You got authorized, chump!";

            return View(result);
        }

        public ActionResult NotAuthorizationIndex()
        {
            string result = "Not authorized!";

            return View(result);
        }
    }
}
