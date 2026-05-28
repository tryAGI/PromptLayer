
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetAllPromptTemplatesGetSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllPromptTemplatesGetSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllPromptTemplatesGetSortOrder value)
        {
            return value switch
            {
                GetAllPromptTemplatesGetSortOrder.Asc => "asc",
                GetAllPromptTemplatesGetSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllPromptTemplatesGetSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetAllPromptTemplatesGetSortOrder.Asc,
                "desc" => GetAllPromptTemplatesGetSortOrder.Desc,
                _ => null,
            };
        }
    }
}