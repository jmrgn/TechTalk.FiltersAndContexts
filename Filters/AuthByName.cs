using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Principal;
using System.Web.Routing;

namespace TechTalk.FiltersAndContexts
{
   
    public class AuthByName : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException("httpContext");

            // Make sure the user is authenticated.
            if (!httpContext.User.Identity.IsAuthenticated)
                return false;
            
            IPrincipal principal = httpContext.User;

            // Do some work to get user info from db & determine whether the request is
            // valid

            if (principal.Identity.Name.Contains("unauthorized"))
            {
                return false;
            }

            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            RouteValueDictionary returnRoute = new RouteValueDictionary();
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                returnRoute["controller"] = "Account";
                returnRoute["action"] = "LogOn";
                returnRoute["returnUrl"] = filterContext.HttpContext.Request.Url.AbsolutePath;
            }
            else
            {
                returnRoute["controller"] = "Account";
                returnRoute["action"] = "Unauthorized";
                returnRoute["returnUrl"] = filterContext.HttpContext.Request.Url.AbsolutePath;
            }
            filterContext.Result = new RedirectToRouteResult(returnRoute); 

        }

    }
}
