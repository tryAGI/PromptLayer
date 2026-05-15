
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListToolRegistriesSortOrder
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
    public static class ListToolRegistriesSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListToolRegistriesSortOrder value)
        {
            return value switch
            {
                ListToolRegistriesSortOrder.Asc => "asc",
                ListToolRegistriesSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListToolRegistriesSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListToolRegistriesSortOrder.Asc,
                "desc" => ListToolRegistriesSortOrder.Desc,
                _ => null,
            };
        }
    }
}