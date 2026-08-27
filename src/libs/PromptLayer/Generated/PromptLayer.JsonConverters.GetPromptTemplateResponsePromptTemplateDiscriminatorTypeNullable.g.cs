#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType? Read(
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
                        return global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
