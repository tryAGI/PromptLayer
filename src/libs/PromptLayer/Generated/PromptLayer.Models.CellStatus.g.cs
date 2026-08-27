
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Current computation status of the cell.
    /// </summary>
    public enum CellStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Error,
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
    public static class CellStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CellStatus value)
        {
            return value switch
            {
                CellStatus.Cancelled => "cancelled",
                CellStatus.Completed => "completed",
                CellStatus.Error => "error",
                CellStatus.Queued => "queued",
                CellStatus.Running => "running",
                CellStatus.Stale => "stale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CellStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => CellStatus.Cancelled,
                "completed" => CellStatus.Completed,
                "error" => CellStatus.Error,
                "queued" => CellStatus.Queued,
                "running" => CellStatus.Running,
                "stale" => CellStatus.Stale,
                _ => null,
            };
        }
    }
}