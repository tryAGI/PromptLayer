
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTableSheetScorecardRowResponseAggregateVerdict
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
    public static class GetTableSheetScorecardRowResponseAggregateVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTableSheetScorecardRowResponseAggregateVerdict value)
        {
            return value switch
            {
                GetTableSheetScorecardRowResponseAggregateVerdict.Error => "error",
                GetTableSheetScorecardRowResponseAggregateVerdict.Fail => "fail",
                GetTableSheetScorecardRowResponseAggregateVerdict.Pass => "pass",
                GetTableSheetScorecardRowResponseAggregateVerdict.Skipped => "skipped",
                GetTableSheetScorecardRowResponseAggregateVerdict.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTableSheetScorecardRowResponseAggregateVerdict? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetTableSheetScorecardRowResponseAggregateVerdict.Error,
                "fail" => GetTableSheetScorecardRowResponseAggregateVerdict.Fail,
                "pass" => GetTableSheetScorecardRowResponseAggregateVerdict.Pass,
                "skipped" => GetTableSheetScorecardRowResponseAggregateVerdict.Skipped,
                "warn" => GetTableSheetScorecardRowResponseAggregateVerdict.Warn,
                _ => null,
            };
        }
    }
}