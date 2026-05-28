
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllPromptTemplatesGetSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllPromptTemplatesGetSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllPromptTemplatesGetSortBy value)
        {
            return value switch
            {
                GetAllPromptTemplatesGetSortBy.CreatedAt => "created_at",
                GetAllPromptTemplatesGetSortBy.Id => "id",
                GetAllPromptTemplatesGetSortBy.Name => "name",
                GetAllPromptTemplatesGetSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllPromptTemplatesGetSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetAllPromptTemplatesGetSortBy.CreatedAt,
                "id" => GetAllPromptTemplatesGetSortBy.Id,
                "name" => GetAllPromptTemplatesGetSortBy.Name,
                "updated_at" => GetAllPromptTemplatesGetSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}