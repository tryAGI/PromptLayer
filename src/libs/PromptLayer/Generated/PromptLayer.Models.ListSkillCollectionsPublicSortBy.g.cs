
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListSkillCollectionsPublicSortBy
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
    public static class ListSkillCollectionsPublicSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSkillCollectionsPublicSortBy value)
        {
            return value switch
            {
                ListSkillCollectionsPublicSortBy.CreatedAt => "created_at",
                ListSkillCollectionsPublicSortBy.Id => "id",
                ListSkillCollectionsPublicSortBy.Name => "name",
                ListSkillCollectionsPublicSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSkillCollectionsPublicSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListSkillCollectionsPublicSortBy.CreatedAt,
                "id" => ListSkillCollectionsPublicSortBy.Id,
                "name" => ListSkillCollectionsPublicSortBy.Name,
                "updated_at" => ListSkillCollectionsPublicSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}