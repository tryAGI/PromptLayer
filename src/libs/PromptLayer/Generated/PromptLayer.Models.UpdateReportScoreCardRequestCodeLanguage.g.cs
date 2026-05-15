
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Language used by the custom scoring code.<br/>
    /// Default Value: PYTHON
    /// </summary>
    public enum UpdateReportScoreCardRequestCodeLanguage
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
    public static class UpdateReportScoreCardRequestCodeLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateReportScoreCardRequestCodeLanguage value)
        {
            return value switch
            {
                UpdateReportScoreCardRequestCodeLanguage.Javascript => "JAVASCRIPT",
                UpdateReportScoreCardRequestCodeLanguage.Python => "PYTHON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateReportScoreCardRequestCodeLanguage? ToEnum(string value)
        {
            return value switch
            {
                "JAVASCRIPT" => UpdateReportScoreCardRequestCodeLanguage.Javascript,
                "PYTHON" => UpdateReportScoreCardRequestCodeLanguage.Python,
                _ => null,
            };
        }
    }
}