
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTableSheetCellRecalculationsBatchResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public string? ExecutionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell_count")]
        public int? CellCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_cell_count")]
        public int? SelectedCellCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetCellRecalculationsBatchResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="executionId"></param>
        /// <param name="cellCount"></param>
        /// <param name="selectedCellCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetCellRecalculationsBatchResponse(
            bool? success,
            string? executionId,
            int? cellCount,
            int? selectedCellCount)
        {
            this.Success = success;
            this.ExecutionId = executionId;
            this.CellCount = cellCount;
            this.SelectedCellCount = selectedCellCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetCellRecalculationsBatchResponse" /> class.
        /// </summary>
        public CreateTableSheetCellRecalculationsBatchResponse()
        {
        }

    }
}