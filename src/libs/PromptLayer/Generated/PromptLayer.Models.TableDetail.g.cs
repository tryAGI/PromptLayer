
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableDetail
    {
        /// <summary>
        /// Map of sheet_id → row count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_row_counts")]
        public global::System.Collections.Generic.Dictionary<string, int>? SheetRowCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableDetail" /> class.
        /// </summary>
        /// <param name="sheetRowCounts">
        /// Map of sheet_id → row count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableDetail(
            global::System.Collections.Generic.Dictionary<string, int>? sheetRowCounts)
        {
            this.SheetRowCounts = sheetRowCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableDetail" /> class.
        /// </summary>
        public TableDetail()
        {
        }

    }
}