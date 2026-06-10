
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Scoring mode. Required when score_config is provided.
    /// </summary>
    public enum ConfigureTableSheetScoreRequestScoreType
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
    public static class ConfigureTableSheetScoreRequestScoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigureTableSheetScoreRequestScoreType value)
        {
            return value switch
            {
                ConfigureTableSheetScoreRequestScoreType.Auto => "auto",
                ConfigureTableSheetScoreRequestScoreType.Boolean => "boolean",
                ConfigureTableSheetScoreRequestScoreType.Custom => "custom",
                ConfigureTableSheetScoreRequestScoreType.Numeric => "numeric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigureTableSheetScoreRequestScoreType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ConfigureTableSheetScoreRequestScoreType.Auto,
                "boolean" => ConfigureTableSheetScoreRequestScoreType.Boolean,
                "custom" => ConfigureTableSheetScoreRequestScoreType.Custom,
                "numeric" => ConfigureTableSheetScoreRequestScoreType.Numeric,
                _ => null,
            };
        }
    }
}