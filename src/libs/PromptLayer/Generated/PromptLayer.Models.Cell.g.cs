
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// A single cell at the intersection of a column and a row.
    /// </summary>
    public sealed partial class Cell
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        public global::System.Guid? SheetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        public global::System.Guid? ColumnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_index")]
        public int? RowIndex { get; set; }

        /// <summary>
        /// Current computation status of the cell.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CellStatusJsonConverter))]
        public global::PromptLayer.CellStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_value")]
        public string? DisplayValue { get; set; }

        /// <summary>
        /// Structured cell value (type depends on column type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Hash of the inputs used to compute this cell, used for cache invalidation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_hash")]
        public string? InputHash { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of the last update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Execution metrics populated for prompt-template column cells. Present only when the cell has an associated request log.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_metrics")]
        public global::PromptLayer.SmartTableRequestMetrics? RequestMetrics { get; set; }

        /// <summary>
        /// Execution ID associated with the current or most recent computed value, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public global::System.Guid? ExecutionId { get; set; }

        /// <summary>
        /// Sheet version_count when this cell was last computed. Null for text cells, virtual cells, or cells that have not completed computation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_computed_version")]
        public int? LastComputedVersion { get; set; }

        /// <summary>
        /// User-visible error message for failed computed cells, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sheetId"></param>
        /// <param name="columnId"></param>
        /// <param name="rowIndex"></param>
        /// <param name="status">
        /// Current computation status of the cell.
        /// </param>
        /// <param name="displayValue"></param>
        /// <param name="value">
        /// Structured cell value (type depends on column type).
        /// </param>
        /// <param name="error"></param>
        /// <param name="inputHash">
        /// Hash of the inputs used to compute this cell, used for cache invalidation.
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of the last update.
        /// </param>
        /// <param name="requestMetrics">
        /// Execution metrics populated for prompt-template column cells. Present only when the cell has an associated request log.
        /// </param>
        /// <param name="executionId">
        /// Execution ID associated with the current or most recent computed value, when available.
        /// </param>
        /// <param name="lastComputedVersion">
        /// Sheet version_count when this cell was last computed. Null for text cells, virtual cells, or cells that have not completed computation.
        /// </param>
        /// <param name="errorMessage">
        /// User-visible error message for failed computed cells, when available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cell(
            global::System.Guid? id,
            global::System.Guid? sheetId,
            global::System.Guid? columnId,
            int? rowIndex,
            global::PromptLayer.CellStatus? status,
            string? displayValue,
            object? value,
            string? error,
            string? inputHash,
            global::System.DateTime? updatedAt,
            global::PromptLayer.SmartTableRequestMetrics? requestMetrics,
            global::System.Guid? executionId,
            int? lastComputedVersion,
            string? errorMessage)
        {
            this.Id = id;
            this.SheetId = sheetId;
            this.ColumnId = columnId;
            this.RowIndex = rowIndex;
            this.Status = status;
            this.DisplayValue = displayValue;
            this.Value = value;
            this.Error = error;
            this.InputHash = inputHash;
            this.UpdatedAt = updatedAt;
            this.RequestMetrics = requestMetrics;
            this.ExecutionId = executionId;
            this.LastComputedVersion = lastComputedVersion;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        public Cell()
        {
        }

    }
}