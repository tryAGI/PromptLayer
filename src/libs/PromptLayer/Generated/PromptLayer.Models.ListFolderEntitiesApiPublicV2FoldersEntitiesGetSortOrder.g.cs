
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder
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
    public static class ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder value)
        {
            return value switch
            {
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder.Asc => "asc",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder.Asc,
                "desc" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder.Desc,
                _ => null,
            };
        }
    }
}