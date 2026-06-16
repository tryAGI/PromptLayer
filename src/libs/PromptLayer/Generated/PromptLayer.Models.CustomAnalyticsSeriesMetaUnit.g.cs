
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Unit hint for rendering axes.
    /// </summary>
    public enum CustomAnalyticsSeriesMetaUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        Currency,
        /// <summary>
        /// 
        /// </summary>
        DurationSeconds,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomAnalyticsSeriesMetaUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAnalyticsSeriesMetaUnit value)
        {
            return value switch
            {
                CustomAnalyticsSeriesMetaUnit.Count => "count",
                CustomAnalyticsSeriesMetaUnit.Currency => "currency",
                CustomAnalyticsSeriesMetaUnit.DurationSeconds => "duration_seconds",
                CustomAnalyticsSeriesMetaUnit.Number => "number",
                CustomAnalyticsSeriesMetaUnit.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAnalyticsSeriesMetaUnit? ToEnum(string value)
        {
            return value switch
            {
                "count" => CustomAnalyticsSeriesMetaUnit.Count,
                "currency" => CustomAnalyticsSeriesMetaUnit.Currency,
                "duration_seconds" => CustomAnalyticsSeriesMetaUnit.DurationSeconds,
                "number" => CustomAnalyticsSeriesMetaUnit.Number,
                "tokens" => CustomAnalyticsSeriesMetaUnit.Tokens,
                _ => null,
            };
        }
    }
}