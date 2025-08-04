using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SampleChannel.Helpers
{
    /**
     * Linnworks may send DateTime strings that do not conform to the standard ISO 8601 format.
     * e.g.: "2025-07-05 03:48:51Z"
     */
    public class FlexibleDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var val = reader.GetString();
            Console.WriteLine($"Flexible: trying to parse DateTime: {val}");
            return DateTime.Parse(val); // Customize as needed
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("o")); // Round-trip format
        }
    }
}