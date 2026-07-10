
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Type of evaluation column to create. Does not include COMPOSITION, which is Tables-only.
    /// </summary>
    public enum EvaluationColumnDefinitionColumnType
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
    public static class EvaluationColumnDefinitionColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationColumnDefinitionColumnType value)
        {
            return value switch
            {
                EvaluationColumnDefinitionColumnType.AbsoluteNumericDistance => "ABSOLUTE_NUMERIC_DISTANCE",
                EvaluationColumnDefinitionColumnType.AiDataExtraction => "AI_DATA_EXTRACTION",
                EvaluationColumnDefinitionColumnType.AssertValid => "ASSERT_VALID",
                EvaluationColumnDefinitionColumnType.Coalesce => "COALESCE",
                EvaluationColumnDefinitionColumnType.CodeExecution => "CODE_EXECUTION",
                EvaluationColumnDefinitionColumnType.CombineColumns => "COMBINE_COLUMNS",
                EvaluationColumnDefinitionColumnType.Compare => "COMPARE",
                EvaluationColumnDefinitionColumnType.Contains => "CONTAINS",
                EvaluationColumnDefinitionColumnType.ConversationSimulator => "CONVERSATION_SIMULATOR",
                EvaluationColumnDefinitionColumnType.CosineSimilarity => "COSINE_SIMILARITY",
                EvaluationColumnDefinitionColumnType.Count => "COUNT",
                EvaluationColumnDefinitionColumnType.Endpoint => "ENDPOINT",
                EvaluationColumnDefinitionColumnType.Human => "HUMAN",
                EvaluationColumnDefinitionColumnType.JsonPath => "JSON_PATH",
                EvaluationColumnDefinitionColumnType.LlmAssertion => "LLM_ASSERTION",
                EvaluationColumnDefinitionColumnType.MathOperator => "MATH_OPERATOR",
                EvaluationColumnDefinitionColumnType.Mcp => "MCP",
                EvaluationColumnDefinitionColumnType.MinMax => "MIN_MAX",
                EvaluationColumnDefinitionColumnType.ParseValue => "PARSE_VALUE",
                EvaluationColumnDefinitionColumnType.PromptTemplate => "PROMPT_TEMPLATE",
                EvaluationColumnDefinitionColumnType.Regex => "REGEX",
                EvaluationColumnDefinitionColumnType.RegexExtraction => "REGEX_EXTRACTION",
                EvaluationColumnDefinitionColumnType.Variable => "VARIABLE",
                EvaluationColumnDefinitionColumnType.Workflow => "WORKFLOW",
                EvaluationColumnDefinitionColumnType.XmlPath => "XML_PATH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationColumnDefinitionColumnType? ToEnum(string value)
        {
            return value switch
            {
                "ABSOLUTE_NUMERIC_DISTANCE" => EvaluationColumnDefinitionColumnType.AbsoluteNumericDistance,
                "AI_DATA_EXTRACTION" => EvaluationColumnDefinitionColumnType.AiDataExtraction,
                "ASSERT_VALID" => EvaluationColumnDefinitionColumnType.AssertValid,
                "COALESCE" => EvaluationColumnDefinitionColumnType.Coalesce,
                "CODE_EXECUTION" => EvaluationColumnDefinitionColumnType.CodeExecution,
                "COMBINE_COLUMNS" => EvaluationColumnDefinitionColumnType.CombineColumns,
                "COMPARE" => EvaluationColumnDefinitionColumnType.Compare,
                "CONTAINS" => EvaluationColumnDefinitionColumnType.Contains,
                "CONVERSATION_SIMULATOR" => EvaluationColumnDefinitionColumnType.ConversationSimulator,
                "COSINE_SIMILARITY" => EvaluationColumnDefinitionColumnType.CosineSimilarity,
                "COUNT" => EvaluationColumnDefinitionColumnType.Count,
                "ENDPOINT" => EvaluationColumnDefinitionColumnType.Endpoint,
                "HUMAN" => EvaluationColumnDefinitionColumnType.Human,
                "JSON_PATH" => EvaluationColumnDefinitionColumnType.JsonPath,
                "LLM_ASSERTION" => EvaluationColumnDefinitionColumnType.LlmAssertion,
                "MATH_OPERATOR" => EvaluationColumnDefinitionColumnType.MathOperator,
                "MCP" => EvaluationColumnDefinitionColumnType.Mcp,
                "MIN_MAX" => EvaluationColumnDefinitionColumnType.MinMax,
                "PARSE_VALUE" => EvaluationColumnDefinitionColumnType.ParseValue,
                "PROMPT_TEMPLATE" => EvaluationColumnDefinitionColumnType.PromptTemplate,
                "REGEX" => EvaluationColumnDefinitionColumnType.Regex,
                "REGEX_EXTRACTION" => EvaluationColumnDefinitionColumnType.RegexExtraction,
                "VARIABLE" => EvaluationColumnDefinitionColumnType.Variable,
                "WORKFLOW" => EvaluationColumnDefinitionColumnType.Workflow,
                "XML_PATH" => EvaluationColumnDefinitionColumnType.XmlPath,
                _ => null,
            };
        }
    }
}