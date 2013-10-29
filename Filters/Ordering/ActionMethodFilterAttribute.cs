using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace TechTalk.FiltersAndContexts
{
    public class ActionMethodFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string order = "+++ActionMethodFilterAttribute.OnActionExecuted";
            Trace.WriteLine(order);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string order = "+++ActionMethodFilterAttribute.OnActionExecuting";
            Trace.WriteLine(order);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string order = "+++ActionMethodFilterAttribute.OnResultExecuted"; ;
            Trace.WriteLine(order);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string order = "+++ActionMethodFilterAttribute.OnResultExecuting";
            Trace.WriteLine(order);
        }
    
    }
}
