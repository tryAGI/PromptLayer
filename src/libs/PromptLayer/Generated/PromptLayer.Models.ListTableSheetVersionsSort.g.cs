
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: version_number
    /// </summary>
    public enum ListTableSheetVersionsSort
    {
        /// <summary>
        /// 
        /// </summary>
        VersionNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTableSheetVersionsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTableSheetVersionsSort value)
        {
            return value switch
            {
                ListTableSheetVersionsSort.VersionNumber => "version_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTableSheetVersionsSort? ToEnum(string value)
        {
            return value switch
            {
                "version_number" => ListTableSheetVersionsSort.VersionNumber,
                _ => null,
            };
        }
    }
}