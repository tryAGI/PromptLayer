
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListTablesOrder
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
    public static class ListTablesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTablesOrder value)
        {
            return value switch
            {
                ListTablesOrder.Asc => "asc",
                ListTablesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTablesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListTablesOrder.Asc,
                "desc" => ListTablesOrder.Desc,
                _ => null,
            };
        }
    }
}