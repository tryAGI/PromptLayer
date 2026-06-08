
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTableSheetColumnRequestType
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
    public static class CreateTableSheetColumnRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTableSheetColumnRequestType value)
        {
            return value switch
            {
                CreateTableSheetColumnRequestType.Code => "code",
                CreateTableSheetColumnRequestType.Comparison => "comparison",
                CreateTableSheetColumnRequestType.Composition => "composition",
                CreateTableSheetColumnRequestType.Llm => "llm",
                CreateTableSheetColumnRequestType.PromptTemplate => "prompt_template",
                CreateTableSheetColumnRequestType.Score => "score",
                CreateTableSheetColumnRequestType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTableSheetColumnRequestType? ToEnum(string value)
        {
            return value switch
            {
                "code" => CreateTableSheetColumnRequestType.Code,
                "comparison" => CreateTableSheetColumnRequestType.Comparison,
                "composition" => CreateTableSheetColumnRequestType.Composition,
                "llm" => CreateTableSheetColumnRequestType.Llm,
                "prompt_template" => CreateTableSheetColumnRequestType.PromptTemplate,
                "score" => CreateTableSheetColumnRequestType.Score,
                "text" => CreateTableSheetColumnRequestType.Text,
                _ => null,
            };
        }
    }
}