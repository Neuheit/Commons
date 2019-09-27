using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Vysn.Comons.Converters
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class SnowflakeConverter : JsonConverter<Snowflake>
    {
        /// <inheritdoc />
        public override Snowflake Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
                return new Snowflake(reader.GetString());

            if (reader.TokenType == JsonTokenType.Number)
                return new Snowflake(reader.GetUInt64());

            throw new JsonException($"Unsupportive token type: {reader.TokenType}");
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Snowflake value, JsonSerializerOptions options)
            => writer.WriteStringValue($"{value.Raw}");
    }
}