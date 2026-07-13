
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceCustomChartSpecMetricField
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
    public static class TraceCustomChartSpecMetricFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecMetricField value)
        {
            return value switch
            {
                TraceCustomChartSpecMetricField.SpanCostUsd => "span_cost_usd",
                TraceCustomChartSpecMetricField.SpanDurationMs => "span_duration_ms",
                TraceCustomChartSpecMetricField.SpanInputTokens => "span_input_tokens",
                TraceCustomChartSpecMetricField.SpanOutputTokens => "span_output_tokens",
                TraceCustomChartSpecMetricField.SpanTokens => "span_tokens",
                TraceCustomChartSpecMetricField.TraceDepth => "trace_depth",
                TraceCustomChartSpecMetricField.TraceDurationMs => "trace_duration_ms",
                TraceCustomChartSpecMetricField.TraceInputTokens => "trace_input_tokens",
                TraceCustomChartSpecMetricField.TraceOutputTokens => "trace_output_tokens",
                TraceCustomChartSpecMetricField.TraceSpanCount => "trace_span_count",
                TraceCustomChartSpecMetricField.TraceTotalCostUsd => "trace_total_cost_usd",
                TraceCustomChartSpecMetricField.TraceTotalTokens => "trace_total_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecMetricField? ToEnum(string value)
        {
            return value switch
            {
                "span_cost_usd" => TraceCustomChartSpecMetricField.SpanCostUsd,
                "span_duration_ms" => TraceCustomChartSpecMetricField.SpanDurationMs,
                "span_input_tokens" => TraceCustomChartSpecMetricField.SpanInputTokens,
                "span_output_tokens" => TraceCustomChartSpecMetricField.SpanOutputTokens,
                "span_tokens" => TraceCustomChartSpecMetricField.SpanTokens,
                "trace_depth" => TraceCustomChartSpecMetricField.TraceDepth,
                "trace_duration_ms" => TraceCustomChartSpecMetricField.TraceDurationMs,
                "trace_input_tokens" => TraceCustomChartSpecMetricField.TraceInputTokens,
                "trace_output_tokens" => TraceCustomChartSpecMetricField.TraceOutputTokens,
                "trace_span_count" => TraceCustomChartSpecMetricField.TraceSpanCount,
                "trace_total_cost_usd" => TraceCustomChartSpecMetricField.TraceTotalCostUsd,
                "trace_total_tokens" => TraceCustomChartSpecMetricField.TraceTotalTokens,
                _ => null,
            };
        }
    }
}