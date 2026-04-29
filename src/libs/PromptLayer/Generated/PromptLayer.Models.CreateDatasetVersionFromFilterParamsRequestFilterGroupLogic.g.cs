
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// How to combine the filters in this group.
    /// </summary>
    public enum CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDatasetVersionFromFilterParamsRequestFilterGroupLogicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic value)
        {
            return value switch
            {
                CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic.And => "AND",
                CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic.Or => "OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic? ToEnum(string value)
        {
            return value switch
            {
                "AND" => CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic.And,
                "OR" => CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic.Or,
                _ => null,
            };
        }
    }
}