
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum RecalculateTableSheetScorecardResponseStatus
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
        Failed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecalculateTableSheetScorecardResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecalculateTableSheetScorecardResponseStatus value)
        {
            return value switch
            {
                RecalculateTableSheetScorecardResponseStatus.Cancelled => "cancelled",
                RecalculateTableSheetScorecardResponseStatus.Completed => "completed",
                RecalculateTableSheetScorecardResponseStatus.Failed => "failed",
                RecalculateTableSheetScorecardResponseStatus.Queued => "queued",
                RecalculateTableSheetScorecardResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecalculateTableSheetScorecardResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => RecalculateTableSheetScorecardResponseStatus.Cancelled,
                "completed" => RecalculateTableSheetScorecardResponseStatus.Completed,
                "failed" => RecalculateTableSheetScorecardResponseStatus.Failed,
                "queued" => RecalculateTableSheetScorecardResponseStatus.Queued,
                "running" => RecalculateTableSheetScorecardResponseStatus.Running,
                _ => null,
            };
        }
    }
}