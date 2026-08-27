#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTableSheetOperationQueuedResponseOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation>
    {
        /// <inheritdoc />
        public override global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation Read(
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
                        return global::PromptLayer.CreateTableSheetOperationQueuedResponseOperationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::PromptLayer.CreateTableSheetOperationQueuedResponseOperationExtensions.ToValueString(value));
        }
    }
}
