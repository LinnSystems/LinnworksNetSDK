using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinnAppFramework.Classes
{
    public class AppController : Controller
    {
        public LinnworksAPI.BaseSession GetLinnworksSesion()
        {
            if(Session["LinnworksSessionId"] == null)
            {
                return null;
            }
            else
            {
                var session = SessionHandler.GetSession(Guid.Parse(Session["LinnworksSessionId"].ToString()));

                return session;
            }
        }
	}
}