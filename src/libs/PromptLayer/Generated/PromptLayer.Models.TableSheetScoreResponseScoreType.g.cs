
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetScoreResponseScoreType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        MultiColumn,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        SingleColumn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableSheetScoreResponseScoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScoreResponseScoreType value)
        {
            return value switch
            {
                TableSheetScoreResponseScoreType.Custom => "custom",
                TableSheetScoreResponseScoreType.MultiColumn => "multi_column",
                TableSheetScoreResponseScoreType.None => "none",
                TableSheetScoreResponseScoreType.SingleColumn => "single_column",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScoreResponseScoreType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TableSheetScoreResponseScoreType.Custom,
                "multi_column" => TableSheetScoreResponseScoreType.MultiColumn,
                "none" => TableSheetScoreResponseScoreType.None,
                "single_column" => TableSheetScoreResponseScoreType.SingleColumn,
                _ => null,
            };
        }
    }
}