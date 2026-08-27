
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListDatasetsSortOrder
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
    public static class ListDatasetsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDatasetsSortOrder value)
        {
            return value switch
            {
                ListDatasetsSortOrder.Asc => "asc",
                ListDatasetsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDatasetsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListDatasetsSortOrder.Asc,
                "desc" => ListDatasetsSortOrder.Desc,
                _ => null,
            };
        }
    }
}