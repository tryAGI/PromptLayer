
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Aggregation function. Omit when using `series` (multi-series mode).
    /// </summary>
    public enum CustomAnalyticsSpecMetric
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
    public static class CustomAnalyticsSpecMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAnalyticsSpecMetric value)
        {
            return value switch
            {
                CustomAnalyticsSpecMetric.Avg => "avg",
                CustomAnalyticsSpecMetric.Count => "count",
                CustomAnalyticsSpecMetric.Max => "max",
                CustomAnalyticsSpecMetric.Min => "min",
                CustomAnalyticsSpecMetric.Percentile => "percentile",
                CustomAnalyticsSpecMetric.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAnalyticsSpecMetric? ToEnum(string value)
        {
            return value switch
            {
                "avg" => CustomAnalyticsSpecMetric.Avg,
                "count" => CustomAnalyticsSpecMetric.Count,
                "max" => CustomAnalyticsSpecMetric.Max,
                "min" => CustomAnalyticsSpecMetric.Min,
                "percentile" => CustomAnalyticsSpecMetric.Percentile,
                "sum" => CustomAnalyticsSpecMetric.Sum,
                _ => null,
            };
        }
    }
}