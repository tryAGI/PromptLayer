
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableCell
    {
        /// <summary>
        /// Cell UUID, or a virtual cell ID for not-yet-computed output cells.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SheetId { get; set; }

        /// <summary>
        /// Execution ID associated with the current or most recent computed value, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public global::System.Guid? ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ColumnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowIndex { get; set; }

        /// <summary>
        /// Sheet version_count when this cell was last computed. Null for text cells, virtual cells, or cells that have not completed computation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_computed_version")]
        public int? LastComputedVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableCellStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableCellStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_value")]
        public string? DisplayValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_hash")]
        public string? InputHash { get; set; }

        /// <summary>
        /// Structured cell value. Shape depends on the column type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

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
        /// Initializes a new instance of the <see cref="TableCell" /> class.
        /// </summary>
        /// <param name="id">
        /// Cell UUID, or a virtual cell ID for not-yet-computed output cells.
        /// </param>
        /// <param name="sheetId"></param>
        /// <param name="columnId"></param>
        /// <param name="rowIndex"></param>
        /// <param name="status"></param>
        /// <param name="executionId">
        /// Execution ID associated with the current or most recent computed value, when available.
        /// </param>
        /// <param name="lastComputedVersion">
        /// Sheet version_count when this cell was last computed. Null for text cells, virtual cells, or cells that have not completed computation.
        /// </param>
        /// <param name="displayValue"></param>
        /// <param name="inputHash"></param>
        /// <param name="value">
        /// Structured cell value. Shape depends on the column type.
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableCell(
            string id,
            global::System.Guid sheetId,
            global::System.Guid columnId,
            int rowIndex,
            global::PromptLayer.TableCellStatus status,
            global::System.Guid? executionId,
            int? lastComputedVersion,
            string? displayValue,
            string? inputHash,
            object? value,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SheetId = sheetId;
            this.ExecutionId = executionId;
            this.ColumnId = columnId;
            this.RowIndex = rowIndex;
            this.LastComputedVersion = lastComputedVersion;
            this.Status = status;
            this.DisplayValue = displayValue;
            this.InputHash = inputHash;
            this.Value = value;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCell" /> class.
        /// </summary>
        public TableCell()
        {
        }

    }
}