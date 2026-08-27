#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDatasetVersionFromFilterParamsRequestSortOrderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder>
    {
        /// <inheritdoc />
        public override global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder Read(
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
                        return global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrderExtensions.ToValueString(value));
        }
    }
}
