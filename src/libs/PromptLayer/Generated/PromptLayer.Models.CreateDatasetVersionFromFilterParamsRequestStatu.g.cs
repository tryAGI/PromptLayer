
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetVersionFromFilterParamsRequestStatu
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDatasetVersionFromFilterParamsRequestStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetVersionFromFilterParamsRequestStatu value)
        {
            return value switch
            {
                CreateDatasetVersionFromFilterParamsRequestStatu.Error => "ERROR",
                CreateDatasetVersionFromFilterParamsRequestStatu.Success => "SUCCESS",
                CreateDatasetVersionFromFilterParamsRequestStatu.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetVersionFromFilterParamsRequestStatu? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => CreateDatasetVersionFromFilterParamsRequestStatu.Error,
                "SUCCESS" => CreateDatasetVersionFromFilterParamsRequestStatu.Success,
                "WARNING" => CreateDatasetVersionFromFilterParamsRequestStatu.Warning,
                _ => null,
            };
        }
    }
}