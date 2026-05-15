
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy
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
    public static class ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy value)
        {
            return value switch
            {
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy.CreatedAt => "created_at",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy.Id => "id",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy.Name => "name",
                ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy.CreatedAt,
                "id" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy.Id,
                "name" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy.Name,
                "updated_at" => ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}