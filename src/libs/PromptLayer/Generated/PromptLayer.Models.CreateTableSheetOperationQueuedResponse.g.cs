
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetOperationQueuedResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationJsonConverter))]
        public global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExecutionIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CellCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtual_cell_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VirtualCellCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cells")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.TableCell> Cells { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetOperationQueuedResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="operationId"></param>
        /// <param name="executionId"></param>
        /// <param name="executionIds"></param>
        /// <param name="cellCount"></param>
        /// <param name="version"></param>
        /// <param name="statusUrl"></param>
        /// <param name="virtualCellCount"></param>
        /// <param name="cells"></param>
        /// <param name="operation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetOperationQueuedResponse(
            bool success,
            string operationId,
            string executionId,
            global::System.Collections.Generic.IList<string> executionIds,
            int cellCount,
            int version,
            string statusUrl,
            int virtualCellCount,
            global::System.Collections.Generic.IList<global::PromptLayer.TableCell> cells,
            global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation operation)
        {
            this.Success = success;
            this.Operation = operation;
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.ExecutionIds = executionIds ?? throw new global::System.ArgumentNullException(nameof(executionIds));
            this.CellCount = cellCount;
            this.Version = version;
            this.StatusUrl = statusUrl ?? throw new global::System.ArgumentNullException(nameof(statusUrl));
            this.VirtualCellCount = virtualCellCount;
            this.Cells = cells ?? throw new global::System.ArgumentNullException(nameof(cells));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetOperationQueuedResponse" /> class.
        /// </summary>
        public CreateTableSheetOperationQueuedResponse()
        {
        }

    }
}