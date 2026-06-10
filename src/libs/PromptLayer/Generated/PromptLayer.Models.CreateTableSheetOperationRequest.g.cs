
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetOperationRequest
    {
        /// <summary>
        /// Default Value: recalculate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationJsonConverter))]
        public global::PromptLayer.CreateTableSheetOperationRequestOperation? Operation { get; set; }

        /// <summary>
        /// Columns to recalculate. Text columns cannot be recalculated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ColumnIds { get; set; }

        /// <summary>
        /// Zero-based row indices to recalculate. If omitted, matching cells across all rows are considered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_ids")]
        public global::System.Collections.Generic.IList<int>? RowIds { get; set; }

        /// <summary>
        /// Cell statuses to include. Defaults to stale cells. Pass an empty array to include all statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetOperationRequestStatuse>? Statuses { get; set; }

        /// <summary>
        /// Confirmation token returned when the operation exceeds the confirmation threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmation_token")]
        public string? ConfirmationToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetOperationRequest" /> class.
        /// </summary>
        /// <param name="operation">
        /// Default Value: recalculate
        /// </param>
        /// <param name="columnIds">
        /// Columns to recalculate. Text columns cannot be recalculated.
        /// </param>
        /// <param name="rowIds">
        /// Zero-based row indices to recalculate. If omitted, matching cells across all rows are considered.
        /// </param>
        /// <param name="statuses">
        /// Cell statuses to include. Defaults to stale cells. Pass an empty array to include all statuses.
        /// </param>
        /// <param name="confirmationToken">
        /// Confirmation token returned when the operation exceeds the confirmation threshold.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetOperationRequest(
            global::PromptLayer.CreateTableSheetOperationRequestOperation? operation,
            global::System.Collections.Generic.IList<global::System.Guid>? columnIds,
            global::System.Collections.Generic.IList<int>? rowIds,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetOperationRequestStatuse>? statuses,
            string? confirmationToken)
        {
            this.Operation = operation;
            this.ColumnIds = columnIds;
            this.RowIds = rowIds;
            this.Statuses = statuses;
            this.ConfirmationToken = confirmationToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetOperationRequest" /> class.
        /// </summary>
        public CreateTableSheetOperationRequest()
        {
        }

    }
}