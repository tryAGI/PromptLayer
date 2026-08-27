#nullable enable

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public sealed class TableSheetScorecardCalculationAggregateVerdictNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict?>
    {
        /// <inheritdoc />
        public override global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict? Read(
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
                        return global::PromptLayer.TableSheetScorecardCalculationAggregateVerdictExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PromptLayer.TableSheetScorecardCalculationAggregateVerdictExtensions.ToValueString(value.Value));
            }
        }
    }
}
