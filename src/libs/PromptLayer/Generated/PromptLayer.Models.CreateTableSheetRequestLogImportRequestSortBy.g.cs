
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Field to sort matching request logs before import.
    /// </summary>
    public enum CreateTableSheetRequestLogImportRequestSortBy
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
    public static class CreateTableSheetRequestLogImportRequestSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTableSheetRequestLogImportRequestSortBy value)
        {
            return value switch
            {
                CreateTableSheetRequestLogImportRequestSortBy.Cost => "cost",
                CreateTableSheetRequestLogImportRequestSortBy.InputTokens => "input_tokens",
                CreateTableSheetRequestLogImportRequestSortBy.LatencyMs => "latency_ms",
                CreateTableSheetRequestLogImportRequestSortBy.OutputTokens => "output_tokens",
                CreateTableSheetRequestLogImportRequestSortBy.RequestStartTime => "request_start_time",
                CreateTableSheetRequestLogImportRequestSortBy.Status => "status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTableSheetRequestLogImportRequestSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateTableSheetRequestLogImportRequestSortBy.Cost,
                "input_tokens" => CreateTableSheetRequestLogImportRequestSortBy.InputTokens,
                "latency_ms" => CreateTableSheetRequestLogImportRequestSortBy.LatencyMs,
                "output_tokens" => CreateTableSheetRequestLogImportRequestSortBy.OutputTokens,
                "request_start_time" => CreateTableSheetRequestLogImportRequestSortBy.RequestStartTime,
                "status" => CreateTableSheetRequestLogImportRequestSortBy.Status,
                _ => null,
            };
        }
    }
}