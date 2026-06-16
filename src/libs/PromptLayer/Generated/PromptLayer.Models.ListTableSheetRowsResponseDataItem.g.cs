
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTableSheetRowsResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_index")]
        public int? RowIndex { get; set; }

        /// <summary>
        /// Map of column_id (UUID string) → cell object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cells")]
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.Cell>? Cells { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetRowsResponseDataItem" /> class.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="cells">
        /// Map of column_id (UUID string) → cell object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTableSheetRowsResponseDataItem(
            int? rowIndex,
            global::System.Collections.Generic.Dictionary<string, global::PromptLayer.Cell>? cells)
        {
            this.RowIndex = rowIndex;
            this.Cells = cells;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetRowsResponseDataItem" /> class.
        /// </summary>
        public ListTableSheetRowsResponseDataItem()
        {
        }

    }
}