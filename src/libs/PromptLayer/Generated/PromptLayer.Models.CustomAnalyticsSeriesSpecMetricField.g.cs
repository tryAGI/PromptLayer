
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Numeric field to aggregate.
    /// </summary>
    public enum CustomAnalyticsSeriesSpecMetricField
    {
        /// <summary>
        ///
        /// </summary>
        CachedTokens,
        /// <summary>
        ///
        /// </summary>
        Cost,
        /// <summary>
        ///
        /// </summary>
        InputTokens,
        /// <summary>
        ///
        /// </summary>
        LatencyMs,
        /// <summary>
        ///
        /// </summary>
        OutputTokens,
        /// <summary>
        ///
        /// </summary>
        PromptVersionNumber,
        /// <summary>
        ///
        /// </summary>
        ThinkingTokens,
        /// <summary>
        ///
        /// </summary>
        ToolCallCount,
        /// <summary>
        ///
        /// </summary>
        TurnCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomAnalyticsSeriesSpecMetricFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAnalyticsSeriesSpecMetricField value)
        {
            return value switch
            {
                CustomAnalyticsSeriesSpecMetricField.CachedTokens => "cached_tokens",
                CustomAnalyticsSeriesSpecMetricField.Cost => "cost",
                CustomAnalyticsSeriesSpecMetricField.InputTokens => "input_tokens",
                CustomAnalyticsSeriesSpecMetricField.LatencyMs => "latency_ms",
                CustomAnalyticsSeriesSpecMetricField.OutputTokens => "output_tokens",
                CustomAnalyticsSeriesSpecMetricField.PromptVersionNumber => "prompt_version_number",
                CustomAnalyticsSeriesSpecMetricField.ThinkingTokens => "thinking_tokens",
                CustomAnalyticsSeriesSpecMetricField.ToolCallCount => "tool_call_count",
                CustomAnalyticsSeriesSpecMetricField.TurnCount => "turn_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAnalyticsSeriesSpecMetricField? ToEnum(string value)
        {
            return value switch
            {
                "cached_tokens" => CustomAnalyticsSeriesSpecMetricField.CachedTokens,
                "cost" => CustomAnalyticsSeriesSpecMetricField.Cost,
                "input_tokens" => CustomAnalyticsSeriesSpecMetricField.InputTokens,
                "latency_ms" => CustomAnalyticsSeriesSpecMetricField.LatencyMs,
                "output_tokens" => CustomAnalyticsSeriesSpecMetricField.OutputTokens,
                "prompt_version_number" => CustomAnalyticsSeriesSpecMetricField.PromptVersionNumber,
                "thinking_tokens" => CustomAnalyticsSeriesSpecMetricField.ThinkingTokens,
                "tool_call_count" => CustomAnalyticsSeriesSpecMetricField.ToolCallCount,
                "turn_count" => CustomAnalyticsSeriesSpecMetricField.TurnCount,
                _ => null,
            };
        }
    }
}