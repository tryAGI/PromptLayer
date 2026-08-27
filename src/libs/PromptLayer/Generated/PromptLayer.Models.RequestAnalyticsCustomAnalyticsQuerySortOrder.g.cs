
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum RequestAnalyticsCustomAnalyticsQuerySortOrder
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
    public static class RequestAnalyticsCustomAnalyticsQuerySortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestAnalyticsCustomAnalyticsQuerySortOrder value)
        {
            return value switch
            {
                RequestAnalyticsCustomAnalyticsQuerySortOrder.Asc => "asc",
                RequestAnalyticsCustomAnalyticsQuerySortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestAnalyticsCustomAnalyticsQuerySortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => RequestAnalyticsCustomAnalyticsQuerySortOrder.Asc,
                "desc" => RequestAnalyticsCustomAnalyticsQuerySortOrder.Desc,
                _ => null,
            };
        }
    }
}