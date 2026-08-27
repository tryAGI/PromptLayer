
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetScorecardStatus
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
        NeedsSetup,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Ready,
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
    public static class TableSheetScorecardStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScorecardStatus value)
        {
            return value switch
            {
                TableSheetScorecardStatus.Completed => "completed",
                TableSheetScorecardStatus.Failed => "failed",
                TableSheetScorecardStatus.NeedsSetup => "needs_setup",
                TableSheetScorecardStatus.Queued => "queued",
                TableSheetScorecardStatus.Ready => "ready",
                TableSheetScorecardStatus.Running => "running",
                TableSheetScorecardStatus.Stale => "stale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScorecardStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TableSheetScorecardStatus.Completed,
                "failed" => TableSheetScorecardStatus.Failed,
                "needs_setup" => TableSheetScorecardStatus.NeedsSetup,
                "queued" => TableSheetScorecardStatus.Queued,
                "ready" => TableSheetScorecardStatus.Ready,
                "running" => TableSheetScorecardStatus.Running,
                "stale" => TableSheetScorecardStatus.Stale,
                _ => null,
            };
        }
    }
}