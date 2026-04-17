#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSkillCollectionPublicFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.GetSkillCollectionPublicFormat>
    {
        /// <inheritdoc />
        public override global::PromptLayer.GetSkillCollectionPublicFormat Read(
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
                        return global::PromptLayer.GetSkillCollectionPublicFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.GetSkillCollectionPublicFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.GetSkillCollectionPublicFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.GetSkillCollectionPublicFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::PromptLayer.GetSkillCollectionPublicFormatExtensions.ToValueString(value));
        }
    }
}
