
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTableSheetOperationRequestStatuse
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Dispatched,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Stale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTableSheetOperationRequestStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTableSheetOperationRequestStatuse value)
        {
            return value switch
            {
                CreateTableSheetOperationRequestStatuse.Completed => "COMPLETED",
                CreateTableSheetOperationRequestStatuse.Dispatched => "DISPATCHED",
                CreateTableSheetOperationRequestStatuse.Failed => "FAILED",
                CreateTableSheetOperationRequestStatuse.Queued => "QUEUED",
                CreateTableSheetOperationRequestStatuse.Running => "RUNNING",
                CreateTableSheetOperationRequestStatuse.Stale => "STALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTableSheetOperationRequestStatuse? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => CreateTableSheetOperationRequestStatuse.Completed,
                "DISPATCHED" => CreateTableSheetOperationRequestStatuse.Dispatched,
                "FAILED" => CreateTableSheetOperationRequestStatuse.Failed,
                "QUEUED" => CreateTableSheetOperationRequestStatuse.Queued,
                "RUNNING" => CreateTableSheetOperationRequestStatuse.Running,
                "STALE" => CreateTableSheetOperationRequestStatuse.Stale,
                _ => null,
            };
        }
    }
}