#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class TraceCustomChartSpecSecondaryGroupByFieldNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField? Read(
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
                        return global::PromptLayer.TraceCustomChartSpecSecondaryGroupByFieldExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.TraceCustomChartSpecSecondaryGroupByFieldExtensions.ToValueString(value.Value));
            }
        }
    }
}
