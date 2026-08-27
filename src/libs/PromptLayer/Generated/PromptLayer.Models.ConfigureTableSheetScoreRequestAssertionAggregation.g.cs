
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Aggregation mode for assertion-style boolean scoring.
    /// </summary>
    public enum ConfigureTableSheetScoreRequestAssertionAggregation
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Any,
        /// <summary>
        ///
        /// </summary>
        Mean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfigureTableSheetScoreRequestAssertionAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigureTableSheetScoreRequestAssertionAggregation value)
        {
            return value switch
            {
                ConfigureTableSheetScoreRequestAssertionAggregation.All => "all",
                ConfigureTableSheetScoreRequestAssertionAggregation.Any => "any",
                ConfigureTableSheetScoreRequestAssertionAggregation.Mean => "mean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigureTableSheetScoreRequestAssertionAggregation? ToEnum(string value)
        {
            return value switch
            {
                "all" => ConfigureTableSheetScoreRequestAssertionAggregation.All,
                "any" => ConfigureTableSheetScoreRequestAssertionAggregation.Any,
                "mean" => ConfigureTableSheetScoreRequestAssertionAggregation.Mean,
                _ => null,
            };
        }
    }
}