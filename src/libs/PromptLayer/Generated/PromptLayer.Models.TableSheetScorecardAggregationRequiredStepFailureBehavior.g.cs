
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
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Ignore,
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
                TableSheetScorecardAggregationRequiredStepFailureBehavior.Fail => "fail",
                TableSheetScorecardAggregationRequiredStepFailureBehavior.Ignore => "ignore",
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
                "fail" => TableSheetScorecardAggregationRequiredStepFailureBehavior.Fail,
                "ignore" => TableSheetScorecardAggregationRequiredStepFailureBehavior.Ignore,
                "warn" => TableSheetScorecardAggregationRequiredStepFailureBehavior.Warn,
                _ => null,
            };
        }
    }
}