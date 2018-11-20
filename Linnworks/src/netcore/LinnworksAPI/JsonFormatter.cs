using Newtonsoft.Json;
using System.Net;

namespace LinnworksAPI
{
    public static class JsonFormatter
    {
        public static JsonSerializerSettings SerializerSettingsDateFormat = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };
        public static JsonSerializerSettings SerializerSettingsIgnoreNullValue = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public static T ConvertFromJson<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value, SerializerSettingsIgnoreNullValue);
        }

        public static string ConvertToJson<T>(T t)
        {
            return WebUtility.UrlEncode(JsonConvert.SerializeObject(t, SerializerSettingsDateFormat));
        }
    }
}
