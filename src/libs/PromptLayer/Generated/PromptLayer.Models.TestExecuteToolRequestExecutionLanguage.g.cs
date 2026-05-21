
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestExecuteToolRequestExecutionLanguage
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
    public static class TestExecuteToolRequestExecutionLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestExecuteToolRequestExecutionLanguage value)
        {
            return value switch
            {
                TestExecuteToolRequestExecutionLanguage.Javascript => "javascript",
                TestExecuteToolRequestExecutionLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestExecuteToolRequestExecutionLanguage? ToEnum(string value)
        {
            return value switch
            {
                "javascript" => TestExecuteToolRequestExecutionLanguage.Javascript,
                "python" => TestExecuteToolRequestExecutionLanguage.Python,
                _ => null,
            };
        }
    }
}