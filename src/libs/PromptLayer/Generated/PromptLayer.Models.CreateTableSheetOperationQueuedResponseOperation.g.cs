
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTableSheetOperationQueuedResponseOperation
    {
        /// <summary>
        ///
        /// </summary>
        Recalculate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTableSheetOperationQueuedResponseOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTableSheetOperationQueuedResponseOperation value)
        {
            return value switch
            {
                CreateTableSheetOperationQueuedResponseOperation.Recalculate => "recalculate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTableSheetOperationQueuedResponseOperation? ToEnum(string value)
        {
            return value switch
            {
                "recalculate" => CreateTableSheetOperationQueuedResponseOperation.Recalculate,
                _ => null,
            };
        }
    }
}