
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ListTableSheetsOrder
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
    public static class ListTableSheetsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTableSheetsOrder value)
        {
            return value switch
            {
                ListTableSheetsOrder.Asc => "asc",
                ListTableSheetsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTableSheetsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListTableSheetsOrder.Asc,
                "desc" => ListTableSheetsOrder.Desc,
                _ => null,
            };
        }
    }
}