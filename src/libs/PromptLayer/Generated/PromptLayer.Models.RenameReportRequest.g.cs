
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Provide name, tags, or both. At least one field is required.
    /// </summary>
    public sealed partial class RenameReportRequest
    {
        /// <summary>
        /// New pipeline name.
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
        /// New pipeline name.
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