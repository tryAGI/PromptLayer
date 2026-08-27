
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetScorecardRowSummaryAggregateVerdict
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Fail,
        /// <summary>
        ///
        /// </summary>
        Pass,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableSheetScorecardRowSummaryAggregateVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScorecardRowSummaryAggregateVerdict value)
        {
            return value switch
            {
                TableSheetScorecardRowSummaryAggregateVerdict.Error => "error",
                TableSheetScorecardRowSummaryAggregateVerdict.Fail => "fail",
                TableSheetScorecardRowSummaryAggregateVerdict.Pass => "pass",
                TableSheetScorecardRowSummaryAggregateVerdict.Skipped => "skipped",
                TableSheetScorecardRowSummaryAggregateVerdict.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScorecardRowSummaryAggregateVerdict? ToEnum(string value)
        {
            return value switch
            {
                "error" => TableSheetScorecardRowSummaryAggregateVerdict.Error,
                "fail" => TableSheetScorecardRowSummaryAggregateVerdict.Fail,
                "pass" => TableSheetScorecardRowSummaryAggregateVerdict.Pass,
                "skipped" => TableSheetScorecardRowSummaryAggregateVerdict.Skipped,
                "warn" => TableSheetScorecardRowSummaryAggregateVerdict.Warn,
                _ => null,
            };
        }
    }
}