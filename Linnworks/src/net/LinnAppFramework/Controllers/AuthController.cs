using System;
using System.Web.Mvc;

namespace LinnAppFramework.Controllers
{
    public class AuthController : Classes.AppController
    {
        public ActionResult Authorize(string id, FormCollection form)
        {
            Guid Token = Guid.Empty;

            if (!Guid.TryParse(id, out Token))
            {
                if (form["token"] != null)
                {
                    if (!Guid.TryParse(form["token"].ToString(), out Token))
                    {
                        return View();
                    }
                }
                else
                {
                    return View();
                }
            }

            var s = Classes.SessionHandler.CreateSession(Token);

            if (s.IsError)
            {
                ViewBag.Error = s.Error;
                return View();
            }
            else
            {
                Session["LinnworksSessionId"] = s.Data.LinnworksSessionId;
            }

            if (Session["LoginRedirect"] != null)
            {
                string url = Session["LoginRedirect"].ToString();

                Session["LoginRedirect"] = null;

                return new RedirectResult(url);
            }

            return new RedirectResult("/Main/Index");
        }

        public ActionResult Setup()
        {
            return View();
        }
    }
}