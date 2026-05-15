
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListSkillCollectionsPublicSortOrder
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
    public static class ListSkillCollectionsPublicSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSkillCollectionsPublicSortOrder value)
        {
            return value switch
            {
                ListSkillCollectionsPublicSortOrder.Asc => "asc",
                ListSkillCollectionsPublicSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSkillCollectionsPublicSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListSkillCollectionsPublicSortOrder.Asc,
                "desc" => ListSkillCollectionsPublicSortOrder.Desc,
                _ => null,
            };
        }
    }
}