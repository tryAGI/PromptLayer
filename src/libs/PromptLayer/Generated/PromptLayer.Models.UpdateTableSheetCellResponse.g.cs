
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateTableSheetCellResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// A single cell at the intersection of a column and a row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell")]
        public global::PromptLayer.Cell? Cell { get; set; }

        /// <summary>
        /// Current sheet version_count for this response. It matches the sheet's version_count after any committed changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Number of downstream cells marked stale due to this edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale_count")]
        public int? StaleCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetCellResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="cell">
        /// A single cell at the intersection of a column and a row.
        /// </param>
        /// <param name="version">
        /// Current sheet version_count for this response. It matches the sheet's version_count after any committed changes.
        /// </param>
        /// <param name="staleCount">
        /// Number of downstream cells marked stale due to this edit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTableSheetCellResponse(
            bool? success,
            global::PromptLayer.Cell? cell,
            int? version,
            int? staleCount)
        {
            this.Success = success;
            this.Cell = cell;
            this.Version = version;
            this.StaleCount = staleCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetCellResponse" /> class.
        /// </summary>
        public UpdateTableSheetCellResponse()
        {
        }

    }
}