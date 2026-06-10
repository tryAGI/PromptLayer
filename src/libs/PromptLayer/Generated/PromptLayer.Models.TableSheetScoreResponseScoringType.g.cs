
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TableSheetScoreResponseScoringType
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
    public static class TableSheetScoreResponseScoringTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScoreResponseScoringType value)
        {
            return value switch
            {
                TableSheetScoreResponseScoringType.Auto => "auto",
                TableSheetScoreResponseScoringType.Boolean => "boolean",
                TableSheetScoreResponseScoringType.Custom => "custom",
                TableSheetScoreResponseScoringType.Numeric => "numeric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScoreResponseScoringType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TableSheetScoreResponseScoringType.Auto,
                "boolean" => TableSheetScoreResponseScoringType.Boolean,
                "custom" => TableSheetScoreResponseScoringType.Custom,
                "numeric" => TableSheetScoreResponseScoringType.Numeric,
                _ => null,
            };
        }
    }
}