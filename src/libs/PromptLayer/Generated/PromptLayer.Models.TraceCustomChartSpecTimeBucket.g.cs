
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceCustomChartSpecTimeBucket
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceCustomChartSpecTimeBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecTimeBucket value)
        {
            return value switch
            {
                TraceCustomChartSpecTimeBucket.Auto => "auto",
                TraceCustomChartSpecTimeBucket.Day => "day",
                TraceCustomChartSpecTimeBucket.Month => "month",
                TraceCustomChartSpecTimeBucket.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecTimeBucket? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TraceCustomChartSpecTimeBucket.Auto,
                "day" => TraceCustomChartSpecTimeBucket.Day,
                "month" => TraceCustomChartSpecTimeBucket.Month,
                "week" => TraceCustomChartSpecTimeBucket.Week,
                _ => null,
            };
        }
    }
}