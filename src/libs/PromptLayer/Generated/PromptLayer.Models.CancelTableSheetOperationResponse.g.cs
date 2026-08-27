
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelTableSheetOperationResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExecutionIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_cell_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CancelledCellCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_started_reset_count")]
        public int? NotStartedResetCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running_invalidated_count")]
        public int? RunningInvalidatedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTableSheetOperationResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="operationId"></param>
        /// <param name="executionIds"></param>
        /// <param name="cancelledCellCount"></param>
        /// <param name="notStartedResetCount"></param>
        /// <param name="runningInvalidatedCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelTableSheetOperationResponse(
            bool success,
            string message,
            string operationId,
            global::System.Collections.Generic.IList<string> executionIds,
            int cancelledCellCount,
            int? notStartedResetCount,
            int? runningInvalidatedCount)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.ExecutionIds = executionIds ?? throw new global::System.ArgumentNullException(nameof(executionIds));
            this.CancelledCellCount = cancelledCellCount;
            this.NotStartedResetCount = notStartedResetCount;
            this.RunningInvalidatedCount = runningInvalidatedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTableSheetOperationResponse" /> class.
        /// </summary>
        public CancelTableSheetOperationResponse()
        {
        }

    }
}