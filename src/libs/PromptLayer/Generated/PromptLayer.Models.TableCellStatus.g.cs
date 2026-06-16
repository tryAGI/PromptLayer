
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TableCellStatus
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
    public static class TableCellStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableCellStatus value)
        {
            return value switch
            {
                TableCellStatus.Completed => "COMPLETED",
                TableCellStatus.Dispatched => "DISPATCHED",
                TableCellStatus.Failed => "FAILED",
                TableCellStatus.Queued => "QUEUED",
                TableCellStatus.Running => "RUNNING",
                TableCellStatus.Stale => "STALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableCellStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => TableCellStatus.Completed,
                "DISPATCHED" => TableCellStatus.Dispatched,
                "FAILED" => TableCellStatus.Failed,
                "QUEUED" => TableCellStatus.Queued,
                "RUNNING" => TableCellStatus.Running,
                "STALE" => TableCellStatus.Stale,
                _ => null,
            };
        }
    }
}