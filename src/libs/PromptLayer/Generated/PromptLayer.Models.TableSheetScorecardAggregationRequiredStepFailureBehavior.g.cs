
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum TableSheetScorecardAggregationRequiredStepFailureBehavior
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
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableSheetScorecardAggregationRequiredStepFailureBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScorecardAggregationRequiredStepFailureBehavior value)
        {
            return value switch
            {
                TableSheetScorecardAggregationRequiredStepFailureBehavior.Error => "error",
                TableSheetScorecardAggregationRequiredStepFailureBehavior.Fail => "fail",
                TableSheetScorecardAggregationRequiredStepFailureBehavior.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScorecardAggregationRequiredStepFailureBehavior? ToEnum(string value)
        {
            return value switch
            {
                "error" => TableSheetScorecardAggregationRequiredStepFailureBehavior.Error,
                "fail" => TableSheetScorecardAggregationRequiredStepFailureBehavior.Fail,
                "warn" => TableSheetScorecardAggregationRequiredStepFailureBehavior.Warn,
                _ => null,
            };
        }
    }
}