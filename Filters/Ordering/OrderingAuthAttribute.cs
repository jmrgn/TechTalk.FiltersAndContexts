using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace TechTalk.FiltersAndContexts
{
    public class OrderingAuthAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            string order = "+OrderingAuth.AuthorizeCore";
            Trace.WriteLine(order);
            
            return true;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            string order = "+OrderingAuth.OnAuthorization";
            Trace.WriteLine(order);
            base.OnAuthorization(filterContext);
        }
    }
}
