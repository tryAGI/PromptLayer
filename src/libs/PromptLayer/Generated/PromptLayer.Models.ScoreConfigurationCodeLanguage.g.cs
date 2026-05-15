
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Language used by the scoring code.<br/>
    /// Default Value: PYTHON
    /// </summary>
    public enum ScoreConfigurationCodeLanguage
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
    public static class ScoreConfigurationCodeLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreConfigurationCodeLanguage value)
        {
            return value switch
            {
                ScoreConfigurationCodeLanguage.Javascript => "JAVASCRIPT",
                ScoreConfigurationCodeLanguage.Python => "PYTHON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreConfigurationCodeLanguage? ToEnum(string value)
        {
            return value switch
            {
                "JAVASCRIPT" => ScoreConfigurationCodeLanguage.Javascript,
                "PYTHON" => ScoreConfigurationCodeLanguage.Python,
                _ => null,
            };
        }
    }
}