#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTableSheetRequestSourceRequestLogsSourceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType? Read(
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
                        return global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
