using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechTalk.FiltersAndContexts.Controllers
{
    [OrderingAuth, ControllerFilter]
    public class OrderingController : Controller
    {
        //
        // GET: /Ordering/
        [ActionMethodFilter]
        public ActionResult Index()
        {
            object order = ControllerContext.HttpContext.Items["Order"];
            return View(order);
        }

    }
}
