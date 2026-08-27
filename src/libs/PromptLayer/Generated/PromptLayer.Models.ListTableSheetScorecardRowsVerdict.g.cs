
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum ListTableSheetScorecardRowsVerdict
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
    public static class ListTableSheetScorecardRowsVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTableSheetScorecardRowsVerdict value)
        {
            return value switch
            {
                ListTableSheetScorecardRowsVerdict.Error => "error",
                ListTableSheetScorecardRowsVerdict.Fail => "fail",
                ListTableSheetScorecardRowsVerdict.Pass => "pass",
                ListTableSheetScorecardRowsVerdict.Skipped => "skipped",
                ListTableSheetScorecardRowsVerdict.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTableSheetScorecardRowsVerdict? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListTableSheetScorecardRowsVerdict.Error,
                "fail" => ListTableSheetScorecardRowsVerdict.Fail,
                "pass" => ListTableSheetScorecardRowsVerdict.Pass,
                "skipped" => ListTableSheetScorecardRowsVerdict.Skipped,
                "warn" => ListTableSheetScorecardRowsVerdict.Warn,
                _ => null,
            };
        }
    }
}