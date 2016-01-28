using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class ExternalApplicationsMethods
    {
        public static void RevokeToken(Guid token, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ExternalApplications/RevokeToken", "token=" + token + "", ApiToken, ApiServer);
        }

        public static Boolean LeaveReview(Guid applicationId, Int32 rating, String comment, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("ExternalApplications/LeaveReview", "applicationId=" + applicationId + "&rating=" + rating + "&comment=" + comment + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GetApplicationResponse GetApplication(Guid applicationId, Boolean loadReviews, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetApplicationResponse>(Factory.GetResponse("ExternalApplications/GetApplication", "applicationId=" + applicationId + "&loadReviews=" + loadReviews + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<DeveloperApplication> SearchApplications(String searchString, Int32 count, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<DeveloperApplication>>(Factory.GetResponse("ExternalApplications/SearchApplications", "searchString=" + searchString + "&count=" + count + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ApplicationToken> GetTokens(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ApplicationToken>>(Factory.GetResponse("ExternalApplications/GetTokens", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ApplicationCategory> GetCategories(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ApplicationCategory>>(Factory.GetResponse("ExternalApplications/GetCategories", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}