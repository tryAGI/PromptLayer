
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomAnalyticsResultChartType
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
    public static class CustomAnalyticsResultChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAnalyticsResultChartType value)
        {
            return value switch
            {
                CustomAnalyticsResultChartType.Area => "area",
                CustomAnalyticsResultChartType.Bar => "bar",
                CustomAnalyticsResultChartType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAnalyticsResultChartType? ToEnum(string value)
        {
            return value switch
            {
                "area" => CustomAnalyticsResultChartType.Area,
                "bar" => CustomAnalyticsResultChartType.Bar,
                "line" => CustomAnalyticsResultChartType.Line,
                _ => null,
            };
        }
    }
}