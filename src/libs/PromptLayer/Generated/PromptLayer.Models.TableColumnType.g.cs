
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Smart Table column type. Use uppercase backend enum values. Input: TEXT. Reference (Tables only, not in legacy evaluation/workflow enums): COMPOSITION. Computed: all other listed values. Create requests also accept lowercase aliases (text, prompt_template, llm, code, score, comparison, composition), which are normalized to uppercase. Legacy DATASET columns are not creatable.
    /// </summary>
    public enum TableColumnType
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
        CombineColumns,
        /// <summary>
        /// 
        /// </summary>
        Compare,
        /// <summary>
        /// TEXT. Reference (Tables only, not in legacy evaluation/workflow enums): COMPOSITION. Computed: all other listed values. Create requests also accept lowercase aliases (text, prompt_template, llm, code, score, comparison, composition), which are normalized to uppercase. Legacy DATASET columns are not creatable.
        /// </summary>
        Composition,
        /// <summary>
        /// 
        /// </summary>
        Condition,
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
        ForLoop,
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
        /// TEXT. Reference (Tables only, not in legacy evaluation/workflow enums): COMPOSITION. Computed: all other listed values. Create requests also accept lowercase aliases (text, prompt_template, llm, code, score, comparison, composition), which are normalized to uppercase. Legacy DATASET columns are not creatable.
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Variable,
        /// <summary>
        /// 
        /// </summary>
        WhileLoop,
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
    public static class TableColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableColumnType value)
        {
            return value switch
            {
                TableColumnType.AbsoluteNumericDistance => "ABSOLUTE_NUMERIC_DISTANCE",
                TableColumnType.AiDataExtraction => "AI_DATA_EXTRACTION",
                TableColumnType.ApplyDiff => "APPLY_DIFF",
                TableColumnType.AssertValid => "ASSERT_VALID",
                TableColumnType.Coalesce => "COALESCE",
                TableColumnType.CodeExecution => "CODE_EXECUTION",
                TableColumnType.CombineColumns => "COMBINE_COLUMNS",
                TableColumnType.Compare => "COMPARE",
                TableColumnType.Composition => "COMPOSITION",
                TableColumnType.Condition => "CONDITION",
                TableColumnType.Contains => "CONTAINS",
                TableColumnType.ConversationSimulator => "CONVERSATION_SIMULATOR",
                TableColumnType.CosineSimilarity => "COSINE_SIMILARITY",
                TableColumnType.Count => "COUNT",
                TableColumnType.Endpoint => "ENDPOINT",
                TableColumnType.ForLoop => "FOR_LOOP",
                TableColumnType.Human => "HUMAN",
                TableColumnType.JsonPath => "JSON_PATH",
                TableColumnType.LlmAssertion => "LLM_ASSERTION",
                TableColumnType.MathOperator => "MATH_OPERATOR",
                TableColumnType.Mcp => "MCP",
                TableColumnType.MinMax => "MIN_MAX",
                TableColumnType.ParseValue => "PARSE_VALUE",
                TableColumnType.PromptTemplate => "PROMPT_TEMPLATE",
                TableColumnType.Regex => "REGEX",
                TableColumnType.RegexExtraction => "REGEX_EXTRACTION",
                TableColumnType.Text => "TEXT",
                TableColumnType.Variable => "VARIABLE",
                TableColumnType.WhileLoop => "WHILE_LOOP",
                TableColumnType.Workflow => "WORKFLOW",
                TableColumnType.XmlPath => "XML_PATH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableColumnType? ToEnum(string value)
        {
            return value switch
            {
                "ABSOLUTE_NUMERIC_DISTANCE" => TableColumnType.AbsoluteNumericDistance,
                "AI_DATA_EXTRACTION" => TableColumnType.AiDataExtraction,
                "APPLY_DIFF" => TableColumnType.ApplyDiff,
                "ASSERT_VALID" => TableColumnType.AssertValid,
                "COALESCE" => TableColumnType.Coalesce,
                "CODE_EXECUTION" => TableColumnType.CodeExecution,
                "COMBINE_COLUMNS" => TableColumnType.CombineColumns,
                "COMPARE" => TableColumnType.Compare,
                "COMPOSITION" => TableColumnType.Composition,
                "CONDITION" => TableColumnType.Condition,
                "CONTAINS" => TableColumnType.Contains,
                "CONVERSATION_SIMULATOR" => TableColumnType.ConversationSimulator,
                "COSINE_SIMILARITY" => TableColumnType.CosineSimilarity,
                "COUNT" => TableColumnType.Count,
                "ENDPOINT" => TableColumnType.Endpoint,
                "FOR_LOOP" => TableColumnType.ForLoop,
                "HUMAN" => TableColumnType.Human,
                "JSON_PATH" => TableColumnType.JsonPath,
                "LLM_ASSERTION" => TableColumnType.LlmAssertion,
                "MATH_OPERATOR" => TableColumnType.MathOperator,
                "MCP" => TableColumnType.Mcp,
                "MIN_MAX" => TableColumnType.MinMax,
                "PARSE_VALUE" => TableColumnType.ParseValue,
                "PROMPT_TEMPLATE" => TableColumnType.PromptTemplate,
                "REGEX" => TableColumnType.Regex,
                "REGEX_EXTRACTION" => TableColumnType.RegexExtraction,
                "TEXT" => TableColumnType.Text,
                "VARIABLE" => TableColumnType.Variable,
                "WHILE_LOOP" => TableColumnType.WhileLoop,
                "WORKFLOW" => TableColumnType.Workflow,
                "XML_PATH" => TableColumnType.XmlPath,
                _ => null,
            };
        }
    }
}