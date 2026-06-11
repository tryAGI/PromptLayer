
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Aggregation function for this series.
    /// </summary>
    public enum CustomAnalyticsSeriesSpecMetric
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
    public static class CustomAnalyticsSeriesSpecMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAnalyticsSeriesSpecMetric value)
        {
            return value switch
            {
                CustomAnalyticsSeriesSpecMetric.Avg => "avg",
                CustomAnalyticsSeriesSpecMetric.Max => "max",
                CustomAnalyticsSeriesSpecMetric.Min => "min",
                CustomAnalyticsSeriesSpecMetric.Percentile => "percentile",
                CustomAnalyticsSeriesSpecMetric.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAnalyticsSeriesSpecMetric? ToEnum(string value)
        {
            return value switch
            {
                "avg" => CustomAnalyticsSeriesSpecMetric.Avg,
                "max" => CustomAnalyticsSeriesSpecMetric.Max,
                "min" => CustomAnalyticsSeriesSpecMetric.Min,
                "percentile" => CustomAnalyticsSeriesSpecMetric.Percentile,
                "sum" => CustomAnalyticsSeriesSpecMetric.Sum,
                _ => null,
            };
        }
    }
}