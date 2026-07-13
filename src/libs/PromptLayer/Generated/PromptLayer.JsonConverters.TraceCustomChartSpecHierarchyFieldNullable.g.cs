#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class TraceCustomChartSpecHierarchyFieldNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.TraceCustomChartSpecHierarchyField?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.TraceCustomChartSpecHierarchyField? Read(
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
                        return global::PromptLayer.TraceCustomChartSpecHierarchyFieldExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.TraceCustomChartSpecHierarchyField)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.TraceCustomChartSpecHierarchyField?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.TraceCustomChartSpecHierarchyField? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.TraceCustomChartSpecHierarchyFieldExtensions.ToValueString(value.Value));
            }
        }
    }
}
