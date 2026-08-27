
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateToolRegistryRequestExecutionLanguage
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
    public static class CreateToolRegistryRequestExecutionLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolRegistryRequestExecutionLanguage value)
        {
            return value switch
            {
                CreateToolRegistryRequestExecutionLanguage.Javascript => "javascript",
                CreateToolRegistryRequestExecutionLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolRegistryRequestExecutionLanguage? ToEnum(string value)
        {
            return value switch
            {
                "javascript" => CreateToolRegistryRequestExecutionLanguage.Javascript,
                "python" => CreateToolRegistryRequestExecutionLanguage.Python,
                _ => null,
            };
        }
    }
}