#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class TableSheetScorecardAggregationRequiredStepFailureBehaviorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior>
    {
        /// <inheritdoc />
        public override global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior Read(
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
                        return global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehaviorExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehaviorExtensions.ToValueString(value));
        }
    }
}
