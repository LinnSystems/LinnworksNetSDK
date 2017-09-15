using Newtonsoft.Json;

namespace LinnworksAPI
{
    public static class MacroMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };
    }
}