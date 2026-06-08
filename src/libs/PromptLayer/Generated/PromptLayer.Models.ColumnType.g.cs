
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Column type. 'text' columns store free-text; 'prompt_template', 'llm', 'code', 'score', 'comparison', and 'composition' columns run automated computations.
    /// </summary>
    public enum ColumnType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Comparison,
        /// <summary>
        /// 
        /// </summary>
        Composition,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        PromptTemplate,
        /// <summary>
        /// 
        /// </summary>
        Score,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColumnType value)
        {
            return value switch
            {
                ColumnType.Code => "code",
                ColumnType.Comparison => "comparison",
                ColumnType.Composition => "composition",
                ColumnType.Llm => "llm",
                ColumnType.PromptTemplate => "prompt_template",
                ColumnType.Score => "score",
                ColumnType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColumnType? ToEnum(string value)
        {
            return value switch
            {
                "code" => ColumnType.Code,
                "comparison" => ColumnType.Comparison,
                "composition" => ColumnType.Composition,
                "llm" => ColumnType.Llm,
                "prompt_template" => ColumnType.PromptTemplate,
                "score" => ColumnType.Score,
                "text" => ColumnType.Text,
                _ => null,
            };
        }
    }
}