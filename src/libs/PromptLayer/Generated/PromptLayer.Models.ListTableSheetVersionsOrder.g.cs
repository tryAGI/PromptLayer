
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListTableSheetVersionsOrder
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
    public static class ListTableSheetVersionsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTableSheetVersionsOrder value)
        {
            return value switch
            {
                ListTableSheetVersionsOrder.Asc => "asc",
                ListTableSheetVersionsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTableSheetVersionsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListTableSheetVersionsOrder.Asc,
                "desc" => ListTableSheetVersionsOrder.Desc,
                _ => null,
            };
        }
    }
}