
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTableSheetRequestSourceFileSourceType
    {
        /// <summary>
        ///
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTableSheetRequestSourceFileSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTableSheetRequestSourceFileSourceType value)
        {
            return value switch
            {
                CreateTableSheetRequestSourceFileSourceType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTableSheetRequestSourceFileSourceType? ToEnum(string value)
        {
            return value switch
            {
                "file" => CreateTableSheetRequestSourceFileSourceType.File,
                _ => null,
            };
        }
    }
}