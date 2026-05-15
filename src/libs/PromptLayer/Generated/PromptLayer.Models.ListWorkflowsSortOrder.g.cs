
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListWorkflowsSortOrder
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
    public static class ListWorkflowsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkflowsSortOrder value)
        {
            return value switch
            {
                ListWorkflowsSortOrder.Asc => "asc",
                ListWorkflowsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkflowsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListWorkflowsSortOrder.Asc,
                "desc" => ListWorkflowsSortOrder.Desc,
                _ => null,
            };
        }
    }
}