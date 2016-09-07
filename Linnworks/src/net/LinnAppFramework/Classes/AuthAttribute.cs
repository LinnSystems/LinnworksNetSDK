using System;
using System.Web;
using System.Web.Mvc;

namespace LinnAppFramework.Classes
{
    public class AuthAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["LinnworksSessionId"] == null)
            {
                // Set the URL so that we can re-direct in the future
                httpContext.Session["LoginRedirect"] = httpContext.Request.Path;

                return false;
            }

            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (Classes.AppSettings.ApplicationId == Guid.Empty || Classes.AppSettings.ApplicationSecret == Guid.Empty)
            {
                filterContext.Result = new RedirectResult("/Auth/Setup");
            }
            else
            {
                filterContext.Result = new RedirectResult("/Auth/Authorize");
            }
        }
    }
}