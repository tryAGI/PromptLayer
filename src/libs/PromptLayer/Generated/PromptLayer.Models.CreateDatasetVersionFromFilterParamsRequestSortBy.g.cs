
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Field to sort results by.
    /// </summary>
    public enum CreateDatasetVersionFromFilterParamsRequestSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        Latency,
        /// <summary>
        /// 
        /// </summary>
        OutputTokens,
        /// <summary>
        /// 
        /// </summary>
        Price,
        /// <summary>
        /// 
        /// </summary>
        PromptName,
        /// <summary>
        /// 
        /// </summary>
        RequestStartTime,
        /// <summary>
        /// 
        /// </summary>
        Score,
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
                CreateDatasetVersionFromFilterParamsRequestSortBy.InputTokens => "input_tokens",
                CreateDatasetVersionFromFilterParamsRequestSortBy.Latency => "latency",
                CreateDatasetVersionFromFilterParamsRequestSortBy.OutputTokens => "output_tokens",
                CreateDatasetVersionFromFilterParamsRequestSortBy.Price => "price",
                CreateDatasetVersionFromFilterParamsRequestSortBy.PromptName => "prompt_name",
                CreateDatasetVersionFromFilterParamsRequestSortBy.RequestStartTime => "request_start_time",
                CreateDatasetVersionFromFilterParamsRequestSortBy.Score => "score",
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
                "input_tokens" => CreateDatasetVersionFromFilterParamsRequestSortBy.InputTokens,
                "latency" => CreateDatasetVersionFromFilterParamsRequestSortBy.Latency,
                "output_tokens" => CreateDatasetVersionFromFilterParamsRequestSortBy.OutputTokens,
                "price" => CreateDatasetVersionFromFilterParamsRequestSortBy.Price,
                "prompt_name" => CreateDatasetVersionFromFilterParamsRequestSortBy.PromptName,
                "request_start_time" => CreateDatasetVersionFromFilterParamsRequestSortBy.RequestStartTime,
                "score" => CreateDatasetVersionFromFilterParamsRequestSortBy.Score,
                "status" => CreateDatasetVersionFromFilterParamsRequestSortBy.Status,
                _ => null,
            };
        }
    }
}