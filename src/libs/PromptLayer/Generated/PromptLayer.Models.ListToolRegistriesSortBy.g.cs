
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListToolRegistriesSortBy
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
    public static class ListToolRegistriesSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListToolRegistriesSortBy value)
        {
            return value switch
            {
                ListToolRegistriesSortBy.CreatedAt => "created_at",
                ListToolRegistriesSortBy.Id => "id",
                ListToolRegistriesSortBy.Name => "name",
                ListToolRegistriesSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListToolRegistriesSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListToolRegistriesSortBy.CreatedAt,
                "id" => ListToolRegistriesSortBy.Id,
                "name" => ListToolRegistriesSortBy.Name,
                "updated_at" => ListToolRegistriesSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}