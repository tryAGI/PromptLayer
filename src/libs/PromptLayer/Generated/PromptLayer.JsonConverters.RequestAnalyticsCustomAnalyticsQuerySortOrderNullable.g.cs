#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestAnalyticsCustomAnalyticsQuerySortOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder? Read(
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
                        return global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
