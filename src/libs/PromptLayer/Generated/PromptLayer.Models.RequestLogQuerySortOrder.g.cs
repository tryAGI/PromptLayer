
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Sort direction. Must be provided together with sort_by.
    /// </summary>
    public enum RequestLogQuerySortOrder
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
    public static class RequestLogQuerySortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestLogQuerySortOrder value)
        {
            return value switch
            {
                RequestLogQuerySortOrder.Asc => "asc",
                RequestLogQuerySortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestLogQuerySortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => RequestLogQuerySortOrder.Asc,
                "desc" => RequestLogQuerySortOrder.Desc,
                _ => null,
            };
        }
    }
}