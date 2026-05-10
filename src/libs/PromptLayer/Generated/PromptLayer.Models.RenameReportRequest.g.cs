
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// At least one of name or tags must be provided.
    /// </summary>
    public sealed partial class RenameReportRequest
    {
        /// <summary>
        /// New name for the evaluation pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Replacement tags. Pass an empty array to clear all tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReportRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the evaluation pipeline.
        /// </param>
        /// <param name="tags">
        /// Replacement tags. Pass an empty array to clear all tags.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenameReportRequest(
            string? name,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReportRequest" /> class.
        /// </summary>
        public RenameReportRequest()
        {
        }

    }
}