
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetScorecardCalculationAggregateVerdict
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
    public static class TableSheetScorecardCalculationAggregateVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScorecardCalculationAggregateVerdict value)
        {
            return value switch
            {
                TableSheetScorecardCalculationAggregateVerdict.Error => "error",
                TableSheetScorecardCalculationAggregateVerdict.Fail => "fail",
                TableSheetScorecardCalculationAggregateVerdict.Pass => "pass",
                TableSheetScorecardCalculationAggregateVerdict.Skipped => "skipped",
                TableSheetScorecardCalculationAggregateVerdict.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScorecardCalculationAggregateVerdict? ToEnum(string value)
        {
            return value switch
            {
                "error" => TableSheetScorecardCalculationAggregateVerdict.Error,
                "fail" => TableSheetScorecardCalculationAggregateVerdict.Fail,
                "pass" => TableSheetScorecardCalculationAggregateVerdict.Pass,
                "skipped" => TableSheetScorecardCalculationAggregateVerdict.Skipped,
                "warn" => TableSheetScorecardCalculationAggregateVerdict.Warn,
                _ => null,
            };
        }
    }
}