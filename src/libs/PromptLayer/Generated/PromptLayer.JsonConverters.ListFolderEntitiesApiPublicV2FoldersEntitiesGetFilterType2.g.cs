#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2>
    {
        /// <inheritdoc />
        public override global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2 Read(
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
                        return global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2Extensions.ToValueString(value));
        }
    }
}
