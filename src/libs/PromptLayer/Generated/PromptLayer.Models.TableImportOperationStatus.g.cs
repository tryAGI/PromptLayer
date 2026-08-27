
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableImportOperationStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableImportOperationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableImportOperationStatus value)
        {
            return value switch
            {
                TableImportOperationStatus.Completed => "completed",
                TableImportOperationStatus.Failed => "failed",
                TableImportOperationStatus.Pending => "pending",
                TableImportOperationStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableImportOperationStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TableImportOperationStatus.Completed,
                "failed" => TableImportOperationStatus.Failed,
                "pending" => TableImportOperationStatus.Pending,
                "running" => TableImportOperationStatus.Running,
                _ => null,
            };
        }
    }
}