
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetOperationOperation
    {
        /// <summary>
        ///
        /// </summary>
        Recalculate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableSheetOperationOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetOperationOperation value)
        {
            return value switch
            {
                TableSheetOperationOperation.Recalculate => "recalculate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetOperationOperation? ToEnum(string value)
        {
            return value switch
            {
                "recalculate" => TableSheetOperationOperation.Recalculate,
                _ => null,
            };
        }
    }
}