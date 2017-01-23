using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldTypes
    {
        Decimal,
        Text,
        List,
        Date,
        Boolean,
        None,
        Button,
        HtmlList,
        Integer,
    }
}