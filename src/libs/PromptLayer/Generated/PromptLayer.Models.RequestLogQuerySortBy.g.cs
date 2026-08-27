
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Field to sort results by. Does not affect aggregated output for `/requests/analytics`.
    /// </summary>
    public enum RequestLogQuerySortBy
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
    public static class RequestLogQuerySortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestLogQuerySortBy value)
        {
            return value switch
            {
                RequestLogQuerySortBy.Cost => "cost",
                RequestLogQuerySortBy.InputTokens => "input_tokens",
                RequestLogQuerySortBy.LatencyMs => "latency_ms",
                RequestLogQuerySortBy.OutputTokens => "output_tokens",
                RequestLogQuerySortBy.RequestStartTime => "request_start_time",
                RequestLogQuerySortBy.Status => "status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestLogQuerySortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => RequestLogQuerySortBy.Cost,
                "input_tokens" => RequestLogQuerySortBy.InputTokens,
                "latency_ms" => RequestLogQuerySortBy.LatencyMs,
                "output_tokens" => RequestLogQuerySortBy.OutputTokens,
                "request_start_time" => RequestLogQuerySortBy.RequestStartTime,
                "status" => RequestLogQuerySortBy.Status,
                _ => null,
            };
        }
    }
}