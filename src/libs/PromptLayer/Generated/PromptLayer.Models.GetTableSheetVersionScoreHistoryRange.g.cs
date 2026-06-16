
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetTableSheetVersionScoreHistoryRange
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Last100,
        /// <summary>
        /// 
        /// </summary>
        Last25,
        /// <summary>
        /// 
        /// </summary>
        Last250,
        /// <summary>
        /// 
        /// </summary>
        Last50,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTableSheetVersionScoreHistoryRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTableSheetVersionScoreHistoryRange value)
        {
            return value switch
            {
                GetTableSheetVersionScoreHistoryRange.All => "all",
                GetTableSheetVersionScoreHistoryRange.Last100 => "last_100",
                GetTableSheetVersionScoreHistoryRange.Last25 => "last_25",
                GetTableSheetVersionScoreHistoryRange.Last250 => "last_250",
                GetTableSheetVersionScoreHistoryRange.Last50 => "last_50",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTableSheetVersionScoreHistoryRange? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetTableSheetVersionScoreHistoryRange.All,
                "last_100" => GetTableSheetVersionScoreHistoryRange.Last100,
                "last_25" => GetTableSheetVersionScoreHistoryRange.Last25,
                "last_250" => GetTableSheetVersionScoreHistoryRange.Last250,
                "last_50" => GetTableSheetVersionScoreHistoryRange.Last50,
                _ => null,
            };
        }
    }
}