using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace TechTalk.FiltersAndContexts
{
    public class ControllerFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string order = "--ControllerFilterAttribute.OnActionExecuted";
            Trace.WriteLine(order);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string order = "--ControllerFilterAttribute.OnActionExecuting";
            Trace.WriteLine(order);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string order = "--ControllerFilterAttribute.OnResultExecuted";
            Trace.WriteLine(order);
            
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string order = "--ControllerFilterAttribute.OnResultExecuting";
            Trace.WriteLine(order);
        }
    
    }
}
