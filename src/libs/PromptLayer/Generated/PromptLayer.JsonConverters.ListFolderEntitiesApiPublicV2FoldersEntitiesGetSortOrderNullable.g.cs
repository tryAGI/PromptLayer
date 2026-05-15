#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder? Read(
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
                        return global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
