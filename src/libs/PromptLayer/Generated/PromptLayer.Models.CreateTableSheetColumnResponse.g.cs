
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetColumnResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// A column within a Table sheet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        public global::PromptLayer.Column? Column { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cells")]
        public global::System.Collections.Generic.IList<global::PromptLayer.Cell>? Cells { get; set; }

        /// <summary>
        /// Current sheet version_count for this response. It matches the sheet's version_count after any committed changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetColumnResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="column">
        /// A column within a Table sheet.
        /// </param>
        /// <param name="cells"></param>
        /// <param name="version">
        /// Current sheet version_count for this response. It matches the sheet's version_count after any committed changes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetColumnResponse(
            bool? success,
            global::PromptLayer.Column? column,
            global::System.Collections.Generic.IList<global::PromptLayer.Cell>? cells,
            int? version)
        {
            this.Success = success;
            this.Column = column;
            this.Cells = cells;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetColumnResponse" /> class.
        /// </summary>
        public CreateTableSheetColumnResponse()
        {
        }

    }
}