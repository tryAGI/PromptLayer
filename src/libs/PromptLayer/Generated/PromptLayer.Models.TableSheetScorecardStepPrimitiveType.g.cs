
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TableSheetScorecardStepPrimitiveType
    {
        /// <summary>
        /// 
        /// </summary>
        AssertValid,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution,
        /// <summary>
        /// 
        /// </summary>
        ColumnAggregate,
        /// <summary>
        /// 
        /// </summary>
        Compare,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        LlmAssertion,
        /// <summary>
        /// 
        /// </summary>
        MaxToolCalls,
        /// <summary>
        /// 
        /// </summary>
        NoInvalidToolCalls,
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        Structure,
        /// <summary>
        /// 
        /// </summary>
        ToolEvaluator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableSheetScorecardStepPrimitiveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScorecardStepPrimitiveType value)
        {
            return value switch
            {
                TableSheetScorecardStepPrimitiveType.AssertValid => "ASSERT_VALID",
                TableSheetScorecardStepPrimitiveType.CodeExecution => "CODE_EXECUTION",
                TableSheetScorecardStepPrimitiveType.ColumnAggregate => "COLUMN_AGGREGATE",
                TableSheetScorecardStepPrimitiveType.Compare => "COMPARE",
                TableSheetScorecardStepPrimitiveType.Contains => "CONTAINS",
                TableSheetScorecardStepPrimitiveType.LlmAssertion => "LLM_ASSERTION",
                TableSheetScorecardStepPrimitiveType.MaxToolCalls => "MAX_TOOL_CALLS",
                TableSheetScorecardStepPrimitiveType.NoInvalidToolCalls => "NO_INVALID_TOOL_CALLS",
                TableSheetScorecardStepPrimitiveType.Regex => "REGEX",
                TableSheetScorecardStepPrimitiveType.Structure => "STRUCTURE",
                TableSheetScorecardStepPrimitiveType.ToolEvaluator => "TOOL_EVALUATOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScorecardStepPrimitiveType? ToEnum(string value)
        {
            return value switch
            {
                "ASSERT_VALID" => TableSheetScorecardStepPrimitiveType.AssertValid,
                "CODE_EXECUTION" => TableSheetScorecardStepPrimitiveType.CodeExecution,
                "COLUMN_AGGREGATE" => TableSheetScorecardStepPrimitiveType.ColumnAggregate,
                "COMPARE" => TableSheetScorecardStepPrimitiveType.Compare,
                "CONTAINS" => TableSheetScorecardStepPrimitiveType.Contains,
                "LLM_ASSERTION" => TableSheetScorecardStepPrimitiveType.LlmAssertion,
                "MAX_TOOL_CALLS" => TableSheetScorecardStepPrimitiveType.MaxToolCalls,
                "NO_INVALID_TOOL_CALLS" => TableSheetScorecardStepPrimitiveType.NoInvalidToolCalls,
                "REGEX" => TableSheetScorecardStepPrimitiveType.Regex,
                "STRUCTURE" => TableSheetScorecardStepPrimitiveType.Structure,
                "TOOL_EVALUATOR" => TableSheetScorecardStepPrimitiveType.ToolEvaluator,
                _ => null,
            };
        }
    }
}