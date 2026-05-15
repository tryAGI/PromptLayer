
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetVersionFromFilterParamsRequestSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        LatencyMs,
        /// <summary>
        /// 
        /// </summary>
        OutputTokens,
        /// <summary>
        /// 
        /// </summary>
        RequestStartTime,
        /// <summary>
        /// 
        /// </summary>
        Status,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDatasetVersionFromFilterParamsRequestSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetVersionFromFilterParamsRequestSortBy value)
        {
            return value switch
            {
                CreateDatasetVersionFromFilterParamsRequestSortBy.Cost => "cost",
                CreateDatasetVersionFromFilterParamsRequestSortBy.InputTokens => "input_tokens",
                CreateDatasetVersionFromFilterParamsRequestSortBy.LatencyMs => "latency_ms",
                CreateDatasetVersionFromFilterParamsRequestSortBy.OutputTokens => "output_tokens",
                CreateDatasetVersionFromFilterParamsRequestSortBy.RequestStartTime => "request_start_time",
                CreateDatasetVersionFromFilterParamsRequestSortBy.Status => "status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetVersionFromFilterParamsRequestSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateDatasetVersionFromFilterParamsRequestSortBy.Cost,
                "input_tokens" => CreateDatasetVersionFromFilterParamsRequestSortBy.InputTokens,
                "latency_ms" => CreateDatasetVersionFromFilterParamsRequestSortBy.LatencyMs,
                "output_tokens" => CreateDatasetVersionFromFilterParamsRequestSortBy.OutputTokens,
                "request_start_time" => CreateDatasetVersionFromFilterParamsRequestSortBy.RequestStartTime,
                "status" => CreateDatasetVersionFromFilterParamsRequestSortBy.Status,
                _ => null,
            };
        }
    }
}