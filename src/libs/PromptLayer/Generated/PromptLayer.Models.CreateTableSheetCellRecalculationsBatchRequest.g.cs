
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetCellRecalculationsBatchRequest
    {
        /// <summary>
        /// List of cell IDs to recalculate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> CellIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetCellRecalculationsBatchRequest" /> class.
        /// </summary>
        /// <param name="cellIds">
        /// List of cell IDs to recalculate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetCellRecalculationsBatchRequest(
            global::System.Collections.Generic.IList<global::System.Guid> cellIds)
        {
            this.CellIds = cellIds ?? throw new global::System.ArgumentNullException(nameof(cellIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetCellRecalculationsBatchRequest" /> class.
        /// </summary>
        public CreateTableSheetCellRecalculationsBatchRequest()
        {
        }

    }
}