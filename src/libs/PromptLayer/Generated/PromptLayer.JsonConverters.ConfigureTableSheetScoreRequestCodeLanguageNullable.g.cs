#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfigureTableSheetScoreRequestCodeLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage? Read(
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
                        return global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
