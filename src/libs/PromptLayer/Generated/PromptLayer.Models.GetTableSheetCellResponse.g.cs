
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTableSheetCellResponse
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetCellResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="cell">
        /// A single cell at the intersection of a column and a row.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTableSheetCellResponse(
            bool? success,
            global::PromptLayer.Cell? cell)
        {
            this.Success = success;
            this.Cell = cell;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetCellResponse" /> class.
        /// </summary>
        public GetTableSheetCellResponse()
        {
        }

    }
}