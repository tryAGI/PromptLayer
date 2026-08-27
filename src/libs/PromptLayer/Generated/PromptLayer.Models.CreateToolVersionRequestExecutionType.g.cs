
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateToolVersionRequestExecutionType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolVersionRequestExecutionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolVersionRequestExecutionType value)
        {
            return value switch
            {
                CreateToolVersionRequestExecutionType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolVersionRequestExecutionType? ToEnum(string value)
        {
            return value switch
            {
                "code" => CreateToolVersionRequestExecutionType.Code,
                _ => null,
            };
        }
    }
}