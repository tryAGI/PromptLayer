
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Column type. DATASET is not allowed.
    /// </summary>
    public enum EditReportColumnRequestColumnType
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
        ApplyDiff,
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
        CodingAgent,
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
    public static class EditReportColumnRequestColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditReportColumnRequestColumnType value)
        {
            return value switch
            {
                EditReportColumnRequestColumnType.AbsoluteNumericDistance => "ABSOLUTE_NUMERIC_DISTANCE",
                EditReportColumnRequestColumnType.AiDataExtraction => "AI_DATA_EXTRACTION",
                EditReportColumnRequestColumnType.ApplyDiff => "APPLY_DIFF",
                EditReportColumnRequestColumnType.AssertValid => "ASSERT_VALID",
                EditReportColumnRequestColumnType.Coalesce => "COALESCE",
                EditReportColumnRequestColumnType.CodeExecution => "CODE_EXECUTION",
                EditReportColumnRequestColumnType.CodingAgent => "CODING_AGENT",
                EditReportColumnRequestColumnType.CombineColumns => "COMBINE_COLUMNS",
                EditReportColumnRequestColumnType.Compare => "COMPARE",
                EditReportColumnRequestColumnType.Contains => "CONTAINS",
                EditReportColumnRequestColumnType.ConversationSimulator => "CONVERSATION_SIMULATOR",
                EditReportColumnRequestColumnType.CosineSimilarity => "COSINE_SIMILARITY",
                EditReportColumnRequestColumnType.Count => "COUNT",
                EditReportColumnRequestColumnType.Endpoint => "ENDPOINT",
                EditReportColumnRequestColumnType.Human => "HUMAN",
                EditReportColumnRequestColumnType.JsonPath => "JSON_PATH",
                EditReportColumnRequestColumnType.LlmAssertion => "LLM_ASSERTION",
                EditReportColumnRequestColumnType.MathOperator => "MATH_OPERATOR",
                EditReportColumnRequestColumnType.Mcp => "MCP",
                EditReportColumnRequestColumnType.MinMax => "MIN_MAX",
                EditReportColumnRequestColumnType.ParseValue => "PARSE_VALUE",
                EditReportColumnRequestColumnType.PromptTemplate => "PROMPT_TEMPLATE",
                EditReportColumnRequestColumnType.Regex => "REGEX",
                EditReportColumnRequestColumnType.RegexExtraction => "REGEX_EXTRACTION",
                EditReportColumnRequestColumnType.Variable => "VARIABLE",
                EditReportColumnRequestColumnType.Workflow => "WORKFLOW",
                EditReportColumnRequestColumnType.XmlPath => "XML_PATH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditReportColumnRequestColumnType? ToEnum(string value)
        {
            return value switch
            {
                "ABSOLUTE_NUMERIC_DISTANCE" => EditReportColumnRequestColumnType.AbsoluteNumericDistance,
                "AI_DATA_EXTRACTION" => EditReportColumnRequestColumnType.AiDataExtraction,
                "APPLY_DIFF" => EditReportColumnRequestColumnType.ApplyDiff,
                "ASSERT_VALID" => EditReportColumnRequestColumnType.AssertValid,
                "COALESCE" => EditReportColumnRequestColumnType.Coalesce,
                "CODE_EXECUTION" => EditReportColumnRequestColumnType.CodeExecution,
                "CODING_AGENT" => EditReportColumnRequestColumnType.CodingAgent,
                "COMBINE_COLUMNS" => EditReportColumnRequestColumnType.CombineColumns,
                "COMPARE" => EditReportColumnRequestColumnType.Compare,
                "CONTAINS" => EditReportColumnRequestColumnType.Contains,
                "CONVERSATION_SIMULATOR" => EditReportColumnRequestColumnType.ConversationSimulator,
                "COSINE_SIMILARITY" => EditReportColumnRequestColumnType.CosineSimilarity,
                "COUNT" => EditReportColumnRequestColumnType.Count,
                "ENDPOINT" => EditReportColumnRequestColumnType.Endpoint,
                "HUMAN" => EditReportColumnRequestColumnType.Human,
                "JSON_PATH" => EditReportColumnRequestColumnType.JsonPath,
                "LLM_ASSERTION" => EditReportColumnRequestColumnType.LlmAssertion,
                "MATH_OPERATOR" => EditReportColumnRequestColumnType.MathOperator,
                "MCP" => EditReportColumnRequestColumnType.Mcp,
                "MIN_MAX" => EditReportColumnRequestColumnType.MinMax,
                "PARSE_VALUE" => EditReportColumnRequestColumnType.ParseValue,
                "PROMPT_TEMPLATE" => EditReportColumnRequestColumnType.PromptTemplate,
                "REGEX" => EditReportColumnRequestColumnType.Regex,
                "REGEX_EXTRACTION" => EditReportColumnRequestColumnType.RegexExtraction,
                "VARIABLE" => EditReportColumnRequestColumnType.Variable,
                "WORKFLOW" => EditReportColumnRequestColumnType.Workflow,
                "XML_PATH" => EditReportColumnRequestColumnType.XmlPath,
                _ => null,
            };
        }
    }
}