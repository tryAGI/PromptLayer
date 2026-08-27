
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateToolRegistryRequestExecutionType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolRegistryRequestExecutionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolRegistryRequestExecutionType value)
        {
            return value switch
            {
                CreateToolRegistryRequestExecutionType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolRegistryRequestExecutionType? ToEnum(string value)
        {
            return value switch
            {
                "code" => CreateToolRegistryRequestExecutionType.Code,
                _ => null,
            };
        }
    }
}