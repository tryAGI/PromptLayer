
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetScorecardCalculationStatus
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
    public static class TableSheetScorecardCalculationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScorecardCalculationStatus value)
        {
            return value switch
            {
                TableSheetScorecardCalculationStatus.Cancelled => "cancelled",
                TableSheetScorecardCalculationStatus.Completed => "completed",
                TableSheetScorecardCalculationStatus.Failed => "failed",
                TableSheetScorecardCalculationStatus.Queued => "queued",
                TableSheetScorecardCalculationStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScorecardCalculationStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => TableSheetScorecardCalculationStatus.Cancelled,
                "completed" => TableSheetScorecardCalculationStatus.Completed,
                "failed" => TableSheetScorecardCalculationStatus.Failed,
                "queued" => TableSheetScorecardCalculationStatus.Queued,
                "running" => TableSheetScorecardCalculationStatus.Running,
                _ => null,
            };
        }
    }
}