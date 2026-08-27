
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetImportStartResponse
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
        /// Status of an asynchronous sheet import operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableImportOperation Operation { get; set; }

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
        /// Initializes a new instance of the <see cref="TableSheetImportStartResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="operationId"></param>
        /// <param name="operation">
        /// Status of an asynchronous sheet import operation.
        /// </param>
        /// <param name="statusUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetImportStartResponse(
            bool success,
            string message,
            string operationId,
            global::PromptLayer.TableImportOperation operation,
            string statusUrl)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.StatusUrl = statusUrl ?? throw new global::System.ArgumentNullException(nameof(statusUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetImportStartResponse" /> class.
        /// </summary>
        public TableSheetImportStartResponse()
        {
        }

    }
}