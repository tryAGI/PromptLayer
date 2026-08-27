
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Status of an asynchronous sheet import operation.
    /// </summary>
    public sealed partial class TableImportOperation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        public string? OperationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableImportOperationSourceJsonConverter))]
        public global::PromptLayer.TableImportOperationSource? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableImportOperationStatusJsonConverter))]
        public global::PromptLayer.TableImportOperationStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_added")]
        public int? RowsAdded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        public int? RowCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableImportOperation" /> class.
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="source"></param>
        /// <param name="status"></param>
        /// <param name="progress"></param>
        /// <param name="message"></param>
        /// <param name="rowsAdded"></param>
        /// <param name="rowCount"></param>
        /// <param name="fileName"></param>
        /// <param name="errorMessage"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableImportOperation(
            string? operationId,
            global::PromptLayer.TableImportOperationSource? source,
            global::PromptLayer.TableImportOperationStatus? status,
            double? progress,
            string? message,
            int? rowsAdded,
            int? rowCount,
            string? fileName,
            string? errorMessage,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.OperationId = operationId;
            this.Source = source;
            this.Status = status;
            this.Progress = progress;
            this.Message = message;
            this.RowsAdded = rowsAdded;
            this.RowCount = rowCount;
            this.FileName = fileName;
            this.ErrorMessage = errorMessage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableImportOperation" /> class.
        /// </summary>
        public TableImportOperation()
        {
        }

    }
}