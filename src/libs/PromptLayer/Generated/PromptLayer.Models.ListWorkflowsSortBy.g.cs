
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum ListWorkflowsSortBy
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
    public static class ListWorkflowsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkflowsSortBy value)
        {
            return value switch
            {
                ListWorkflowsSortBy.CreatedAt => "created_at",
                ListWorkflowsSortBy.Id => "id",
                ListWorkflowsSortBy.Name => "name",
                ListWorkflowsSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkflowsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListWorkflowsSortBy.CreatedAt,
                "id" => ListWorkflowsSortBy.Id,
                "name" => ListWorkflowsSortBy.Name,
                "updated_at" => ListWorkflowsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}