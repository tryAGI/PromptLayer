
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTableSheetVersionRequest
    {
        /// <summary>
        /// Version name. Required when source_version_id is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Existing version to restore from while creating a new version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_version_id")]
        public global::System.Guid? SourceVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetVersionRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Version name. Required when source_version_id is omitted.
        /// </param>
        /// <param name="sourceVersionId">
        /// Existing version to restore from while creating a new version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetVersionRequest(
            string? name,
            global::System.Guid? sourceVersionId)
        {
            this.Name = name;
            this.SourceVersionId = sourceVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetVersionRequest" /> class.
        /// </summary>
        public CreateTableSheetVersionRequest()
        {
        }

    }
}