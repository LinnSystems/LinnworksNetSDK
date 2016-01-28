using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class AccountMethods
    {
        public static String Account_GenerateAnywhereToken(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Account/Account_GenerateAnywhereToken", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void Test(String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Account/Test", "", ApiToken, ApiServer);
        }

        public static List<String> Helpers_Country_List(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Account/Helpers_Country_List", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CountryVatInfo Helpers_Vatin_GetCountryVatInfo(String country, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CountryVatInfo>(Factory.GetResponse("Account/Helpers_Vatin_GetCountryVatInfo", "country=" + country + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AccountDetails AccountDetails_Get(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AccountDetails>(Factory.GetResponse("Account/AccountDetails_Get", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AccountDetails_Update_ContactDetails(ContactDetails details, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Account/AccountDetails_Update_ContactDetails", "details=" + Newtonsoft.Json.JsonConvert.SerializeObject(details) + "", ApiToken, ApiServer);
        }

        public static void AccountDetails_Update_ForumName(String forumName, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Account/AccountDetails_Update_ForumName", "forumName=" + forumName + "", ApiToken, ApiServer);
        }
    }
}