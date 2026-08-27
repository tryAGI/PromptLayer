
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Accepted for compatibility; does not affect aggregated output.
    /// </summary>
    public enum RequestAnalyticsCustomAnalyticsQuerySortBy
    {
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
        RequestStartTime,
        /// <summary>
        ///
        /// </summary>
        Status,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestAnalyticsCustomAnalyticsQuerySortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestAnalyticsCustomAnalyticsQuerySortBy value)
        {
            return value switch
            {
                RequestAnalyticsCustomAnalyticsQuerySortBy.Cost => "cost",
                RequestAnalyticsCustomAnalyticsQuerySortBy.InputTokens => "input_tokens",
                RequestAnalyticsCustomAnalyticsQuerySortBy.LatencyMs => "latency_ms",
                RequestAnalyticsCustomAnalyticsQuerySortBy.OutputTokens => "output_tokens",
                RequestAnalyticsCustomAnalyticsQuerySortBy.RequestStartTime => "request_start_time",
                RequestAnalyticsCustomAnalyticsQuerySortBy.Status => "status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestAnalyticsCustomAnalyticsQuerySortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => RequestAnalyticsCustomAnalyticsQuerySortBy.Cost,
                "input_tokens" => RequestAnalyticsCustomAnalyticsQuerySortBy.InputTokens,
                "latency_ms" => RequestAnalyticsCustomAnalyticsQuerySortBy.LatencyMs,
                "output_tokens" => RequestAnalyticsCustomAnalyticsQuerySortBy.OutputTokens,
                "request_start_time" => RequestAnalyticsCustomAnalyticsQuerySortBy.RequestStartTime,
                "status" => RequestAnalyticsCustomAnalyticsQuerySortBy.Status,
                _ => null,
            };
        }
    }
}