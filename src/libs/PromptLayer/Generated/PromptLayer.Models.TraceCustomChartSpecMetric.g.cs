
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceCustomChartSpecMetric
    {
        /// <summary>
        /// 
        /// </summary>
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Count,
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
    public static class TraceCustomChartSpecMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecMetric value)
        {
            return value switch
            {
                TraceCustomChartSpecMetric.Avg => "avg",
                TraceCustomChartSpecMetric.Count => "count",
                TraceCustomChartSpecMetric.Max => "max",
                TraceCustomChartSpecMetric.Min => "min",
                TraceCustomChartSpecMetric.Percentile => "percentile",
                TraceCustomChartSpecMetric.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecMetric? ToEnum(string value)
        {
            return value switch
            {
                "avg" => TraceCustomChartSpecMetric.Avg,
                "count" => TraceCustomChartSpecMetric.Count,
                "max" => TraceCustomChartSpecMetric.Max,
                "min" => TraceCustomChartSpecMetric.Min,
                "percentile" => TraceCustomChartSpecMetric.Percentile,
                "sum" => TraceCustomChartSpecMetric.Sum,
                _ => null,
            };
        }
    }
}