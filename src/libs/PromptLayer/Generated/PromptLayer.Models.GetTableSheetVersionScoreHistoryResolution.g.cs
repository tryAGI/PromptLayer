
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum GetTableSheetVersionScoreHistoryResolution
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        MinMaxBucket,
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTableSheetVersionScoreHistoryResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTableSheetVersionScoreHistoryResolution value)
        {
            return value switch
            {
                GetTableSheetVersionScoreHistoryResolution.Auto => "auto",
                GetTableSheetVersionScoreHistoryResolution.MinMaxBucket => "min_max_bucket",
                GetTableSheetVersionScoreHistoryResolution.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTableSheetVersionScoreHistoryResolution? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetTableSheetVersionScoreHistoryResolution.Auto,
                "min_max_bucket" => GetTableSheetVersionScoreHistoryResolution.MinMaxBucket,
                "raw" => GetTableSheetVersionScoreHistoryResolution.Raw,
                _ => null,
            };
        }
    }
}