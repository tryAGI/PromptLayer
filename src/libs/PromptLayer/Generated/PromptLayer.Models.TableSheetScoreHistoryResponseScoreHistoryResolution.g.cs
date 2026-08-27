
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetScoreHistoryResponseScoreHistoryResolution
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
    public static class TableSheetScoreHistoryResponseScoreHistoryResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScoreHistoryResponseScoreHistoryResolution value)
        {
            return value switch
            {
                TableSheetScoreHistoryResponseScoreHistoryResolution.Auto => "auto",
                TableSheetScoreHistoryResponseScoreHistoryResolution.MinMaxBucket => "min_max_bucket",
                TableSheetScoreHistoryResponseScoreHistoryResolution.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScoreHistoryResponseScoreHistoryResolution? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TableSheetScoreHistoryResponseScoreHistoryResolution.Auto,
                "min_max_bucket" => TableSheetScoreHistoryResponseScoreHistoryResolution.MinMaxBucket,
                "raw" => TableSheetScoreHistoryResponseScoreHistoryResolution.Raw,
                _ => null,
            };
        }
    }
}