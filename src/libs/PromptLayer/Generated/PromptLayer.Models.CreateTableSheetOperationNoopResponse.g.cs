
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTableSheetOperationNoopResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CellCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtual_cell_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VirtualCellCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cells")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.TableCell> Cells { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetOperationNoopResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="cellCount"></param>
        /// <param name="virtualCellCount"></param>
        /// <param name="cells"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetOperationNoopResponse(
            bool success,
            int cellCount,
            int virtualCellCount,
            global::System.Collections.Generic.IList<global::PromptLayer.TableCell> cells)
        {
            this.Success = success;
            this.CellCount = cellCount;
            this.VirtualCellCount = virtualCellCount;
            this.Cells = cells ?? throw new global::System.ArgumentNullException(nameof(cells));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetOperationNoopResponse" /> class.
        /// </summary>
        public CreateTableSheetOperationNoopResponse()
        {
        }

    }
}