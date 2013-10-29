using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechTalk.FiltersAndContexts
{
    public class HandleErrorWrapperAttribute : HandleErrorAttribute
    {

        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception.GetType() == typeof(CustomException))
            {
                // do something special
                // handle the exception
                filterContext.ExceptionHandled = true;
                
            }

            base.OnException(filterContext);
        }

    }
}