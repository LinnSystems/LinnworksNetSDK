using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinnAppFramework.Classes
{
    public static class LinnInterop
    {
        public static Core.GenericTypedResponse<LinnworksAPI.BaseSession> GetSession(Guid Token)
        {
            LinnworksAPI.BaseSession Session = LinnworksAPI.AuthMethods.AuthorizeByApplication(AppSettings.ApplicationId, AppSettings.ApplicationSecret, Token);

            if(Session == null)
            {
                return new Core.GenericTypedResponse<LinnworksAPI.BaseSession>() { IsError = true, Error = "Could not verify session. Check ApplicationId, ApplicationSecret and Token validity" };
            }

            return new Core.GenericTypedResponse<LinnworksAPI.BaseSession>() { Data = Session };
        }
    }
}