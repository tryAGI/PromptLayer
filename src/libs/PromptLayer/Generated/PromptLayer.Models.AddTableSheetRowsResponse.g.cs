
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTableSheetRowsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_created")]
        public int? RowsCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_row_index")]
        public int? StartRowIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_indices")]
        public global::System.Collections.Generic.IList<int>? RowIndices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::PromptLayer.AddTableSheetRowsResponseRow>? Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell_count")]
        public int? CellCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        public int? RowCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTableSheetRowsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="rowsCreated"></param>
        /// <param name="startRowIndex"></param>
        /// <param name="rowIndices"></param>
        /// <param name="rows"></param>
        /// <param name="cellCount"></param>
        /// <param name="rowCount"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTableSheetRowsResponse(
            bool? success,
            int? rowsCreated,
            int? startRowIndex,
            global::System.Collections.Generic.IList<int>? rowIndices,
            global::System.Collections.Generic.IList<global::PromptLayer.AddTableSheetRowsResponseRow>? rows,
            int? cellCount,
            int? rowCount,
            int? version)
        {
            this.Success = success;
            this.RowsCreated = rowsCreated;
            this.StartRowIndex = startRowIndex;
            this.RowIndices = rowIndices;
            this.Rows = rows;
            this.CellCount = cellCount;
            this.RowCount = rowCount;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTableSheetRowsResponse" /> class.
        /// </summary>
        public AddTableSheetRowsResponse()
        {
        }

    }
}