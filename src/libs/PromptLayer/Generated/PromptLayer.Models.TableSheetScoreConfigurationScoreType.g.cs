
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TableSheetScoreConfigurationScoreType
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
    public static class TableSheetScoreConfigurationScoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScoreConfigurationScoreType value)
        {
            return value switch
            {
                TableSheetScoreConfigurationScoreType.Auto => "auto",
                TableSheetScoreConfigurationScoreType.Boolean => "boolean",
                TableSheetScoreConfigurationScoreType.Custom => "custom",
                TableSheetScoreConfigurationScoreType.Numeric => "numeric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScoreConfigurationScoreType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TableSheetScoreConfigurationScoreType.Auto,
                "boolean" => TableSheetScoreConfigurationScoreType.Boolean,
                "custom" => TableSheetScoreConfigurationScoreType.Custom,
                "numeric" => TableSheetScoreConfigurationScoreType.Numeric,
                _ => null,
            };
        }
    }
}