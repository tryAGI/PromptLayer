
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ListTableSheetRowsOrder
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
    public static class ListTableSheetRowsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTableSheetRowsOrder value)
        {
            return value switch
            {
                ListTableSheetRowsOrder.Asc => "asc",
                ListTableSheetRowsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTableSheetRowsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListTableSheetRowsOrder.Asc,
                "desc" => ListTableSheetRowsOrder.Desc,
                _ => null,
            };
        }
    }
}