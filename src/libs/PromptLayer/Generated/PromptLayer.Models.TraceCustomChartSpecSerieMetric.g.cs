
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceCustomChartSpecSerieMetric
    {
        /// <summary>
        /// 
        /// </summary>
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Percentile,
        /// <summary>
        /// 
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceCustomChartSpecSerieMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecSerieMetric value)
        {
            return value switch
            {
                TraceCustomChartSpecSerieMetric.Avg => "avg",
                TraceCustomChartSpecSerieMetric.Max => "max",
                TraceCustomChartSpecSerieMetric.Min => "min",
                TraceCustomChartSpecSerieMetric.Percentile => "percentile",
                TraceCustomChartSpecSerieMetric.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecSerieMetric? ToEnum(string value)
        {
            return value switch
            {
                "avg" => TraceCustomChartSpecSerieMetric.Avg,
                "max" => TraceCustomChartSpecSerieMetric.Max,
                "min" => TraceCustomChartSpecSerieMetric.Min,
                "percentile" => TraceCustomChartSpecSerieMetric.Percentile,
                "sum" => TraceCustomChartSpecSerieMetric.Sum,
                _ => null,
            };
        }
    }
}