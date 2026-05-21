
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestExecuteToolRequestExecutionType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestExecuteToolRequestExecutionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestExecuteToolRequestExecutionType value)
        {
            return value switch
            {
                TestExecuteToolRequestExecutionType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestExecuteToolRequestExecutionType? ToEnum(string value)
        {
            return value switch
            {
                "code" => TestExecuteToolRequestExecutionType.Code,
                _ => null,
            };
        }
    }
}