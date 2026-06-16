
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTableSheetColumnResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_recalculation")]
        public bool? RequiresRecalculation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affected_column_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AffectedColumnIds { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateTableSheetColumnResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="column">
        /// A column within a Table sheet.
        /// </param>
        /// <param name="requiresRecalculation"></param>
        /// <param name="affectedColumnIds"></param>
        /// <param name="version">
        /// Current sheet version_count for this response. It matches the sheet's version_count after any committed changes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTableSheetColumnResponse(
            bool? success,
            global::PromptLayer.Column? column,
            bool? requiresRecalculation,
            global::System.Collections.Generic.IList<global::System.Guid>? affectedColumnIds,
            int? version)
        {
            this.Success = success;
            this.Column = column;
            this.RequiresRecalculation = requiresRecalculation;
            this.AffectedColumnIds = affectedColumnIds;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetColumnResponse" /> class.
        /// </summary>
        public UpdateTableSheetColumnResponse()
        {
        }

    }
}