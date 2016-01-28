using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class AuthMethods
    {
        public static Object GetDebugInformation(String key, String password)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Object>(Factory.GetResponse("Auth/GetDebugInformation", "key=" + key + "&password=" + password + "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<BaseUser> MultiLogin(String userName, String password)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BaseUser>>(Factory.GetResponse("Auth/MultiLogin", "userName=" + userName + "&password=" + password + "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static BaseSession Authorize(String userName, String password, Guid userId)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BaseSession>(Factory.GetResponse("Auth/Authorize", "userName=" + userName + "&password=" + password + "&userId=" + userId + "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RequestPasswordReset(String userName)
        {
            Factory.GetResponse("Auth/RequestPasswordReset", "userName=" + userName + "", "", "");
        }

        public static void ResetPassword(String UserName, Guid ResetToken, String NewPassword, String ConfirmNewPassword)
        {
            Factory.GetResponse("Auth/ResetPassword", "UserName=" + UserName + "&ResetToken=" + ResetToken + "&NewPassword=" + NewPassword + "&ConfirmNewPassword=" + ConfirmNewPassword + "", "", "");
        }

        public static BaseSession AuthorizeByApplication(Guid applicationId, Guid applicationSecret, Guid token)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BaseSession>(Factory.GetResponse("Auth/AuthorizeByApplication", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&token=" + token + "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static DateTime GetServerUTCTime()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(Factory.GetResponse("Auth/GetServerUTCTime", "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}