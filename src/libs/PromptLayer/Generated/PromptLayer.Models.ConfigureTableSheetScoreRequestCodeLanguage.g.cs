
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: PYTHON
    /// </summary>
    public enum ConfigureTableSheetScoreRequestCodeLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Javascript,
        /// <summary>
        ///
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfigureTableSheetScoreRequestCodeLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigureTableSheetScoreRequestCodeLanguage value)
        {
            return value switch
            {
                ConfigureTableSheetScoreRequestCodeLanguage.Javascript => "JAVASCRIPT",
                ConfigureTableSheetScoreRequestCodeLanguage.Python => "PYTHON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigureTableSheetScoreRequestCodeLanguage? ToEnum(string value)
        {
            return value switch
            {
                "JAVASCRIPT" => ConfigureTableSheetScoreRequestCodeLanguage.Javascript,
                "PYTHON" => ConfigureTableSheetScoreRequestCodeLanguage.Python,
                _ => null,
            };
        }
    }
}