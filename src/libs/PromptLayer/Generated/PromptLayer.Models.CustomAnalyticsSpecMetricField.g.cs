
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Numeric field to aggregate. Required unless metric is `count` or using multi-series mode.
    /// </summary>
    public enum CustomAnalyticsSpecMetricField
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
    public static class CustomAnalyticsSpecMetricFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAnalyticsSpecMetricField value)
        {
            return value switch
            {
                CustomAnalyticsSpecMetricField.CachedTokens => "cached_tokens",
                CustomAnalyticsSpecMetricField.Cost => "cost",
                CustomAnalyticsSpecMetricField.InputTokens => "input_tokens",
                CustomAnalyticsSpecMetricField.LatencyMs => "latency_ms",
                CustomAnalyticsSpecMetricField.OutputTokens => "output_tokens",
                CustomAnalyticsSpecMetricField.PromptVersionNumber => "prompt_version_number",
                CustomAnalyticsSpecMetricField.ThinkingTokens => "thinking_tokens",
                CustomAnalyticsSpecMetricField.ToolCallCount => "tool_call_count",
                CustomAnalyticsSpecMetricField.TurnCount => "turn_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAnalyticsSpecMetricField? ToEnum(string value)
        {
            return value switch
            {
                "cached_tokens" => CustomAnalyticsSpecMetricField.CachedTokens,
                "cost" => CustomAnalyticsSpecMetricField.Cost,
                "input_tokens" => CustomAnalyticsSpecMetricField.InputTokens,
                "latency_ms" => CustomAnalyticsSpecMetricField.LatencyMs,
                "output_tokens" => CustomAnalyticsSpecMetricField.OutputTokens,
                "prompt_version_number" => CustomAnalyticsSpecMetricField.PromptVersionNumber,
                "thinking_tokens" => CustomAnalyticsSpecMetricField.ThinkingTokens,
                "tool_call_count" => CustomAnalyticsSpecMetricField.ToolCallCount,
                "turn_count" => CustomAnalyticsSpecMetricField.TurnCount,
                _ => null,
            };
        }
    }
}