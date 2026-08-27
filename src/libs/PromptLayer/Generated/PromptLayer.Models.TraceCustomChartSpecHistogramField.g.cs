
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Histogram charts only
    /// </summary>
    public enum TraceCustomChartSpecHistogramField
    {
        /// <summary>
        ///
        /// </summary>
        SpanCostUsd,
        /// <summary>
        ///
        /// </summary>
        SpanDurationMs,
        /// <summary>
        ///
        /// </summary>
        SpanInputTokens,
        /// <summary>
        ///
        /// </summary>
        SpanOutputTokens,
        /// <summary>
        ///
        /// </summary>
        SpanTokens,
        /// <summary>
        ///
        /// </summary>
        TraceDepth,
        /// <summary>
        ///
        /// </summary>
        TraceDurationMs,
        /// <summary>
        ///
        /// </summary>
        TraceInputTokens,
        /// <summary>
        ///
        /// </summary>
        TraceOutputTokens,
        /// <summary>
        ///
        /// </summary>
        TraceSpanCount,
        /// <summary>
        ///
        /// </summary>
        TraceTotalCostUsd,
        /// <summary>
        ///
        /// </summary>
        TraceTotalTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceCustomChartSpecHistogramFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecHistogramField value)
        {
            return value switch
            {
                TraceCustomChartSpecHistogramField.SpanCostUsd => "span_cost_usd",
                TraceCustomChartSpecHistogramField.SpanDurationMs => "span_duration_ms",
                TraceCustomChartSpecHistogramField.SpanInputTokens => "span_input_tokens",
                TraceCustomChartSpecHistogramField.SpanOutputTokens => "span_output_tokens",
                TraceCustomChartSpecHistogramField.SpanTokens => "span_tokens",
                TraceCustomChartSpecHistogramField.TraceDepth => "trace_depth",
                TraceCustomChartSpecHistogramField.TraceDurationMs => "trace_duration_ms",
                TraceCustomChartSpecHistogramField.TraceInputTokens => "trace_input_tokens",
                TraceCustomChartSpecHistogramField.TraceOutputTokens => "trace_output_tokens",
                TraceCustomChartSpecHistogramField.TraceSpanCount => "trace_span_count",
                TraceCustomChartSpecHistogramField.TraceTotalCostUsd => "trace_total_cost_usd",
                TraceCustomChartSpecHistogramField.TraceTotalTokens => "trace_total_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecHistogramField? ToEnum(string value)
        {
            return value switch
            {
                "span_cost_usd" => TraceCustomChartSpecHistogramField.SpanCostUsd,
                "span_duration_ms" => TraceCustomChartSpecHistogramField.SpanDurationMs,
                "span_input_tokens" => TraceCustomChartSpecHistogramField.SpanInputTokens,
                "span_output_tokens" => TraceCustomChartSpecHistogramField.SpanOutputTokens,
                "span_tokens" => TraceCustomChartSpecHistogramField.SpanTokens,
                "trace_depth" => TraceCustomChartSpecHistogramField.TraceDepth,
                "trace_duration_ms" => TraceCustomChartSpecHistogramField.TraceDurationMs,
                "trace_input_tokens" => TraceCustomChartSpecHistogramField.TraceInputTokens,
                "trace_output_tokens" => TraceCustomChartSpecHistogramField.TraceOutputTokens,
                "trace_span_count" => TraceCustomChartSpecHistogramField.TraceSpanCount,
                "trace_total_cost_usd" => TraceCustomChartSpecHistogramField.TraceTotalCostUsd,
                "trace_total_tokens" => TraceCustomChartSpecHistogramField.TraceTotalTokens,
                _ => null,
            };
        }
    }
}