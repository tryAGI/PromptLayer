
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetOperation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetOperationOperationJsonConverter))]
        public global::PromptLayer.TableSheetOperationOperation Operation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> StatusCounts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CellCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletedCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetOperation" /> class.
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="status"></param>
        /// <param name="statusCounts"></param>
        /// <param name="cellCount"></param>
        /// <param name="completedCount"></param>
        /// <param name="failedCount"></param>
        /// <param name="pendingCount"></param>
        /// <param name="statusUrl"></param>
        /// <param name="operation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetOperation(
            string operationId,
            string status,
            global::System.Collections.Generic.Dictionary<string, int> statusCounts,
            int cellCount,
            int completedCount,
            int failedCount,
            int pendingCount,
            string statusUrl,
            global::PromptLayer.TableSheetOperationOperation operation)
        {
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.Operation = operation;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StatusCounts = statusCounts ?? throw new global::System.ArgumentNullException(nameof(statusCounts));
            this.CellCount = cellCount;
            this.CompletedCount = completedCount;
            this.FailedCount = failedCount;
            this.PendingCount = pendingCount;
            this.StatusUrl = statusUrl ?? throw new global::System.ArgumentNullException(nameof(statusUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetOperation" /> class.
        /// </summary>
        public TableSheetOperation()
        {
        }

    }
}