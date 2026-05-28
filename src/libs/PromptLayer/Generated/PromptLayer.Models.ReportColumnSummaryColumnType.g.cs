
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReportColumnSummaryColumnType
    {
        /// <summary>
        /// 
        /// </summary>
        AbsoluteNumericDistance,
        /// <summary>
        /// 
        /// </summary>
        AiDataExtraction,
        /// <summary>
        /// 
        /// </summary>
        AssertValid,
        /// <summary>
        /// 
        /// </summary>
        Coalesce,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution,
        /// <summary>
        /// 
        /// </summary>
        CombineColumns,
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
        ConversationSimulator,
        /// <summary>
        /// 
        /// </summary>
        CosineSimilarity,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Endpoint,
        /// <summary>
        /// 
        /// </summary>
        Human,
        /// <summary>
        /// 
        /// </summary>
        JsonPath,
        /// <summary>
        /// 
        /// </summary>
        LlmAssertion,
        /// <summary>
        /// 
        /// </summary>
        MathOperator,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        MinMax,
        /// <summary>
        /// 
        /// </summary>
        ParseValue,
        /// <summary>
        /// 
        /// </summary>
        PromptTemplate,
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        RegexExtraction,
        /// <summary>
        /// 
        /// </summary>
        Variable,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
        /// <summary>
        /// 
        /// </summary>
        XmlPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportColumnSummaryColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportColumnSummaryColumnType value)
        {
            return value switch
            {
                ReportColumnSummaryColumnType.AbsoluteNumericDistance => "ABSOLUTE_NUMERIC_DISTANCE",
                ReportColumnSummaryColumnType.AiDataExtraction => "AI_DATA_EXTRACTION",
                ReportColumnSummaryColumnType.AssertValid => "ASSERT_VALID",
                ReportColumnSummaryColumnType.Coalesce => "COALESCE",
                ReportColumnSummaryColumnType.CodeExecution => "CODE_EXECUTION",
                ReportColumnSummaryColumnType.CombineColumns => "COMBINE_COLUMNS",
                ReportColumnSummaryColumnType.Compare => "COMPARE",
                ReportColumnSummaryColumnType.Contains => "CONTAINS",
                ReportColumnSummaryColumnType.ConversationSimulator => "CONVERSATION_SIMULATOR",
                ReportColumnSummaryColumnType.CosineSimilarity => "COSINE_SIMILARITY",
                ReportColumnSummaryColumnType.Count => "COUNT",
                ReportColumnSummaryColumnType.Dataset => "DATASET",
                ReportColumnSummaryColumnType.Endpoint => "ENDPOINT",
                ReportColumnSummaryColumnType.Human => "HUMAN",
                ReportColumnSummaryColumnType.JsonPath => "JSON_PATH",
                ReportColumnSummaryColumnType.LlmAssertion => "LLM_ASSERTION",
                ReportColumnSummaryColumnType.MathOperator => "MATH_OPERATOR",
                ReportColumnSummaryColumnType.Mcp => "MCP",
                ReportColumnSummaryColumnType.MinMax => "MIN_MAX",
                ReportColumnSummaryColumnType.ParseValue => "PARSE_VALUE",
                ReportColumnSummaryColumnType.PromptTemplate => "PROMPT_TEMPLATE",
                ReportColumnSummaryColumnType.Regex => "REGEX",
                ReportColumnSummaryColumnType.RegexExtraction => "REGEX_EXTRACTION",
                ReportColumnSummaryColumnType.Variable => "VARIABLE",
                ReportColumnSummaryColumnType.Workflow => "WORKFLOW",
                ReportColumnSummaryColumnType.XmlPath => "XML_PATH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportColumnSummaryColumnType? ToEnum(string value)
        {
            return value switch
            {
                "ABSOLUTE_NUMERIC_DISTANCE" => ReportColumnSummaryColumnType.AbsoluteNumericDistance,
                "AI_DATA_EXTRACTION" => ReportColumnSummaryColumnType.AiDataExtraction,
                "ASSERT_VALID" => ReportColumnSummaryColumnType.AssertValid,
                "COALESCE" => ReportColumnSummaryColumnType.Coalesce,
                "CODE_EXECUTION" => ReportColumnSummaryColumnType.CodeExecution,
                "COMBINE_COLUMNS" => ReportColumnSummaryColumnType.CombineColumns,
                "COMPARE" => ReportColumnSummaryColumnType.Compare,
                "CONTAINS" => ReportColumnSummaryColumnType.Contains,
                "CONVERSATION_SIMULATOR" => ReportColumnSummaryColumnType.ConversationSimulator,
                "COSINE_SIMILARITY" => ReportColumnSummaryColumnType.CosineSimilarity,
                "COUNT" => ReportColumnSummaryColumnType.Count,
                "DATASET" => ReportColumnSummaryColumnType.Dataset,
                "ENDPOINT" => ReportColumnSummaryColumnType.Endpoint,
                "HUMAN" => ReportColumnSummaryColumnType.Human,
                "JSON_PATH" => ReportColumnSummaryColumnType.JsonPath,
                "LLM_ASSERTION" => ReportColumnSummaryColumnType.LlmAssertion,
                "MATH_OPERATOR" => ReportColumnSummaryColumnType.MathOperator,
                "MCP" => ReportColumnSummaryColumnType.Mcp,
                "MIN_MAX" => ReportColumnSummaryColumnType.MinMax,
                "PARSE_VALUE" => ReportColumnSummaryColumnType.ParseValue,
                "PROMPT_TEMPLATE" => ReportColumnSummaryColumnType.PromptTemplate,
                "REGEX" => ReportColumnSummaryColumnType.Regex,
                "REGEX_EXTRACTION" => ReportColumnSummaryColumnType.RegexExtraction,
                "VARIABLE" => ReportColumnSummaryColumnType.Variable,
                "WORKFLOW" => ReportColumnSummaryColumnType.Workflow,
                "XML_PATH" => ReportColumnSummaryColumnType.XmlPath,
                _ => null,
            };
        }
    }
}