
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum DatasetRowCellType
    {
        /// <summary>
        ///
        /// </summary>
        Dataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetRowCellTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetRowCellType value)
        {
            return value switch
            {
                DatasetRowCellType.Dataset => "dataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetRowCellType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => DatasetRowCellType.Dataset,
                _ => null,
            };
        }
    }
}