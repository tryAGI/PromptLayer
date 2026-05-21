
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateToolVersionRequestExecutionLanguage
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
    public static class CreateToolVersionRequestExecutionLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolVersionRequestExecutionLanguage value)
        {
            return value switch
            {
                CreateToolVersionRequestExecutionLanguage.Javascript => "javascript",
                CreateToolVersionRequestExecutionLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolVersionRequestExecutionLanguage? ToEnum(string value)
        {
            return value switch
            {
                "javascript" => CreateToolVersionRequestExecutionLanguage.Javascript,
                "python" => CreateToolVersionRequestExecutionLanguage.Python,
                _ => null,
            };
        }
    }
}