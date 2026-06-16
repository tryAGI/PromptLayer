
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTableSheetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// A sheet within a Table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet")]
        public global::PromptLayer.Sheet? Sheet { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateTableSheetResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="sheet">
        /// A sheet within a Table.
        /// </param>
        /// <param name="version">
        /// Current sheet version_count for this response. It matches the sheet's version_count after any committed changes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTableSheetResponse(
            bool? success,
            global::PromptLayer.Sheet? sheet,
            int? version)
        {
            this.Success = success;
            this.Sheet = sheet;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetResponse" /> class.
        /// </summary>
        public UpdateTableSheetResponse()
        {
        }

    }
}