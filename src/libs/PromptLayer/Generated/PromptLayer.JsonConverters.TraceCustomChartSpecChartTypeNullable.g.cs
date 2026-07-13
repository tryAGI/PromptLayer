#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class TraceCustomChartSpecChartTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.TraceCustomChartSpecChartType?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.TraceCustomChartSpecChartType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::PromptLayer.TraceCustomChartSpecChartTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.TraceCustomChartSpecChartType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.TraceCustomChartSpecChartType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.TraceCustomChartSpecChartType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.TraceCustomChartSpecChartTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
