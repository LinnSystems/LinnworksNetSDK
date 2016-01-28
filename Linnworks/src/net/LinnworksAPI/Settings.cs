using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class SettingsMethods
    {
        public static void AddSetting(String category, String setting, String value, Boolean userSpecific, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Settings/AddSetting", "category=" + category + "&setting=" + setting + "&value=" + value + "&userSpecific=" + userSpecific + "", ApiToken, ApiServer);
        }

        public static void DeleteSetting(String category, String setting, Boolean userSpecific, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Settings/DeleteSetting", "category=" + category + "&setting=" + setting + "&userSpecific=" + userSpecific + "", ApiToken, ApiServer);
        }

        public static Dictionary<String, List<AppSetting>> GetSettings(List<String> categories, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, List<AppSetting>>>(Factory.GetResponse("Settings/GetSettings", "categories=" + Newtonsoft.Json.JsonConvert.SerializeObject(categories) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Boolean IsCustomerAuthorized(String module, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("Settings/IsCustomerAuthorized", "module=" + module + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Boolean IsBetaApplied(String module, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("Settings/IsBetaApplied", "module=" + module + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RequestCustomerAccess(String module, String name, String telephone, DateTime time, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Settings/RequestCustomerAccess", "module=" + module + "&name=" + name + "&telephone=" + telephone + "&time=" + Newtonsoft.Json.JsonConvert.SerializeObject(time) + "", ApiToken, ApiServer);
        }

        public static Measures GetMeasures(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Measures>(Factory.GetResponse("Settings/GetMeasures", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String GetXmlSetting(String name, String category, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Settings/GetXmlSetting", "name=" + name + "&category=" + category + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}