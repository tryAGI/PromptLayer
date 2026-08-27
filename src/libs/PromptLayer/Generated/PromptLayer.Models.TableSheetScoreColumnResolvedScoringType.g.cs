
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetScoreColumnResolvedScoringType
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableSheetScoreColumnResolvedScoringTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScoreColumnResolvedScoringType value)
        {
            return value switch
            {
                TableSheetScoreColumnResolvedScoringType.Auto => "auto",
                TableSheetScoreColumnResolvedScoringType.Boolean => "boolean",
                TableSheetScoreColumnResolvedScoringType.Custom => "custom",
                TableSheetScoreColumnResolvedScoringType.Numeric => "numeric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScoreColumnResolvedScoringType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TableSheetScoreColumnResolvedScoringType.Auto,
                "boolean" => TableSheetScoreColumnResolvedScoringType.Boolean,
                "custom" => TableSheetScoreColumnResolvedScoringType.Custom,
                "numeric" => TableSheetScoreColumnResolvedScoringType.Numeric,
                _ => null,
            };
        }
    }
}