
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Sort direction. Must be provided together with sort_by.
    /// </summary>
    public enum CreateTableSheetRequestLogImportRequestSortOrder
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
    public static class CreateTableSheetRequestLogImportRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTableSheetRequestLogImportRequestSortOrder value)
        {
            return value switch
            {
                CreateTableSheetRequestLogImportRequestSortOrder.Asc => "asc",
                CreateTableSheetRequestLogImportRequestSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTableSheetRequestLogImportRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => CreateTableSheetRequestLogImportRequestSortOrder.Asc,
                "desc" => CreateTableSheetRequestLogImportRequestSortOrder.Desc,
                _ => null,
            };
        }
    }
}