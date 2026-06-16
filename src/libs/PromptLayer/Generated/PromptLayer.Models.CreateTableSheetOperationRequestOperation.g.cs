
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: recalculate
    /// </summary>
    public enum CreateTableSheetOperationRequestOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Recalculate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTableSheetOperationRequestOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTableSheetOperationRequestOperation value)
        {
            return value switch
            {
                CreateTableSheetOperationRequestOperation.Recalculate => "recalculate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTableSheetOperationRequestOperation? ToEnum(string value)
        {
            return value switch
            {
                "recalculate" => CreateTableSheetOperationRequestOperation.Recalculate,
                _ => null,
            };
        }
    }
}