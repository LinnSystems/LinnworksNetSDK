using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EvaluatorGroup
    {
        BasicEquality,
        Range,
        Set,
        NumberEquality,
        StringEquality,
    }
}