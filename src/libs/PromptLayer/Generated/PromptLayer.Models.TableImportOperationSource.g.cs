
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableImportOperationSource
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        RequestLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableImportOperationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableImportOperationSource value)
        {
            return value switch
            {
                TableImportOperationSource.File => "file",
                TableImportOperationSource.RequestLogs => "request_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableImportOperationSource? ToEnum(string value)
        {
            return value switch
            {
                "file" => TableImportOperationSource.File,
                "request_logs" => TableImportOperationSource.RequestLogs,
                _ => null,
            };
        }
    }
}