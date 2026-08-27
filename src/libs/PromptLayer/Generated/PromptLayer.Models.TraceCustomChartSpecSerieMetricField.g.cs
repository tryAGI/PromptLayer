
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TraceCustomChartSpecSerieMetricField
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
    public static class TraceCustomChartSpecSerieMetricFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecSerieMetricField value)
        {
            return value switch
            {
                TraceCustomChartSpecSerieMetricField.SpanCostUsd => "span_cost_usd",
                TraceCustomChartSpecSerieMetricField.SpanDurationMs => "span_duration_ms",
                TraceCustomChartSpecSerieMetricField.SpanInputTokens => "span_input_tokens",
                TraceCustomChartSpecSerieMetricField.SpanOutputTokens => "span_output_tokens",
                TraceCustomChartSpecSerieMetricField.SpanTokens => "span_tokens",
                TraceCustomChartSpecSerieMetricField.TraceDepth => "trace_depth",
                TraceCustomChartSpecSerieMetricField.TraceDurationMs => "trace_duration_ms",
                TraceCustomChartSpecSerieMetricField.TraceInputTokens => "trace_input_tokens",
                TraceCustomChartSpecSerieMetricField.TraceOutputTokens => "trace_output_tokens",
                TraceCustomChartSpecSerieMetricField.TraceSpanCount => "trace_span_count",
                TraceCustomChartSpecSerieMetricField.TraceTotalCostUsd => "trace_total_cost_usd",
                TraceCustomChartSpecSerieMetricField.TraceTotalTokens => "trace_total_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecSerieMetricField? ToEnum(string value)
        {
            return value switch
            {
                "span_cost_usd" => TraceCustomChartSpecSerieMetricField.SpanCostUsd,
                "span_duration_ms" => TraceCustomChartSpecSerieMetricField.SpanDurationMs,
                "span_input_tokens" => TraceCustomChartSpecSerieMetricField.SpanInputTokens,
                "span_output_tokens" => TraceCustomChartSpecSerieMetricField.SpanOutputTokens,
                "span_tokens" => TraceCustomChartSpecSerieMetricField.SpanTokens,
                "trace_depth" => TraceCustomChartSpecSerieMetricField.TraceDepth,
                "trace_duration_ms" => TraceCustomChartSpecSerieMetricField.TraceDurationMs,
                "trace_input_tokens" => TraceCustomChartSpecSerieMetricField.TraceInputTokens,
                "trace_output_tokens" => TraceCustomChartSpecSerieMetricField.TraceOutputTokens,
                "trace_span_count" => TraceCustomChartSpecSerieMetricField.TraceSpanCount,
                "trace_total_cost_usd" => TraceCustomChartSpecSerieMetricField.TraceTotalCostUsd,
                "trace_total_tokens" => TraceCustomChartSpecSerieMetricField.TraceTotalTokens,
                _ => null,
            };
        }
    }
}