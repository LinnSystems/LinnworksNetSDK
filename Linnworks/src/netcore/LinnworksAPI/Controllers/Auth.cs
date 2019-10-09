using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class AuthController : BaseController, IAuthController
    {
        public AuthController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Generates a sesssion and provide Authorization Token and server in response. 
        /// </summary>
        /// <param name="request"></param>
        public BaseSession AuthorizeByApplication(AuthorizeByApplicationRequest request)
		{
			var response = GetResponse("Auth/AuthorizeByApplication", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<BaseSession>(response);
		}

		/// <summary>
        /// Returns current application subscription profile information for a given application for a specific user. 
        /// You can use this method to get the current application subscription after AuthorizedByApplication returned a session. 
        /// The session will contain Id, this is the UserId you need to supply in the call.
        /// If there are no current subscriptions for the application for the user. The method will return null (nothing) 
        /// </summary>
        /// <param name="applicationId">Your application Id</param>
        /// <param name="applicationSecret">Your application secret key</param>
        /// <param name="userId">User Id (Id field of the session)</param>
        /// <returns>Class that represents the application subscription profile</returns>
        public ApplicationProfileResponse GetApplicationProfileBySecretKey(Guid applicationId,Guid applicationSecret,Guid userId)
		{
			var response = GetResponse("Auth/GetApplicationProfileBySecretKey", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&userId=" + userId + "");
            return JsonFormatter.ConvertFromJson<ApplicationProfileResponse>(response);
		}

		public DateTime GetServerUTCTime()
		{
			var response = GetResponse("Auth/GetServerUTCTime", "");
            return JsonFormatter.ConvertFromJson<DateTime>(response);
		} 
    }
}