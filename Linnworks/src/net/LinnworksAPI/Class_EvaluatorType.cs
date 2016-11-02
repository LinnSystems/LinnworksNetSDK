using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EvaluatorType
    {
        Default,
        BetweenExclusive,
        BetweenInclusive,
        GreaterThan,
        GreaterThanOrEqualTo,
        LessThan,
        LessThanOrEqualTo,
        Equals,
        NotEquals,
        StartsWith,
        NotStartsWith,
        EndsWith,
        NotEndsWith,
        Contains,
        NotContains,
        RegexMatch,
        NotRegexMatch,
        InSet,
        NotInSet,
        StartsWithSetValue,
        NotStartsWithSetValue,
        EndsWithSetValue,
        NotEndsWithSetValue,
        ContainsSetValue,
        NotContainsSetValue,
        RegexMatchSetValue,
        NotRegexMatchSetValue,
    }
}