
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDatasetsSortBy
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
    public static class ListDatasetsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDatasetsSortBy value)
        {
            return value switch
            {
                ListDatasetsSortBy.CreatedAt => "created_at",
                ListDatasetsSortBy.Id => "id",
                ListDatasetsSortBy.Name => "name",
                ListDatasetsSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDatasetsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListDatasetsSortBy.CreatedAt,
                "id" => ListDatasetsSortBy.Id,
                "name" => ListDatasetsSortBy.Name,
                "updated_at" => ListDatasetsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}