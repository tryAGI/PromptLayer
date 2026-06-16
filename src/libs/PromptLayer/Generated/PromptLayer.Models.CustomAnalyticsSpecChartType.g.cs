
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Chart visualization type. Overall aggregate charts (no timeSeries, no groupByField) must use `bar`.
    /// </summary>
    public enum CustomAnalyticsSpecChartType
    {
        /// <summary>
        /// 
        /// </summary>
        Area,
        /// <summary>
        /// 
        /// </summary>
        Bar,
        /// <summary>
        /// 
        /// </summary>
        Line,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomAnalyticsSpecChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAnalyticsSpecChartType value)
        {
            return value switch
            {
                CustomAnalyticsSpecChartType.Area => "area",
                CustomAnalyticsSpecChartType.Bar => "bar",
                CustomAnalyticsSpecChartType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAnalyticsSpecChartType? ToEnum(string value)
        {
            return value switch
            {
                "area" => CustomAnalyticsSpecChartType.Area,
                "bar" => CustomAnalyticsSpecChartType.Bar,
                "line" => CustomAnalyticsSpecChartType.Line,
                _ => null,
            };
        }
    }
}