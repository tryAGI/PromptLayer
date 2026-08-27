
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDatasetVersionFromFilterParamsRequestSortOrder
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
    public static class CreateDatasetVersionFromFilterParamsRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetVersionFromFilterParamsRequestSortOrder value)
        {
            return value switch
            {
                CreateDatasetVersionFromFilterParamsRequestSortOrder.Asc => "asc",
                CreateDatasetVersionFromFilterParamsRequestSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetVersionFromFilterParamsRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => CreateDatasetVersionFromFilterParamsRequestSortOrder.Asc,
                "desc" => CreateDatasetVersionFromFilterParamsRequestSortOrder.Desc,
                _ => null,
            };
        }
    }
}