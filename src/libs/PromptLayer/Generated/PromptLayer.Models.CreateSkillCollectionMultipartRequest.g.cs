
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSkillCollectionMultipartRequest
    {
        /// <summary>
        /// JSON string metadata containing `name`, `folder_id`, `provider`, `files`, and `commit_message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Alternative metadata JSON string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public string? Json { get; set; }

        /// <summary>
        /// Optional ZIP archive upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive")]
        public byte[]? Archive { get; set; }

        /// <summary>
        /// Optional ZIP archive upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivename")]
        public string? Archivename { get; set; }

        /// <summary>
        /// Optional ZIP archive upload alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        public byte[]? Zip { get; set; }

        /// <summary>
        /// Optional ZIP archive upload alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zipname")]
        public string? Zipname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillCollectionMultipartRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// JSON string metadata containing `name`, `folder_id`, `provider`, `files`, and `commit_message`.
        /// </param>
        /// <param name="json">
        /// Alternative metadata JSON string.
        /// </param>
        /// <param name="archive">
        /// Optional ZIP archive upload.
        /// </param>
        /// <param name="archivename">
        /// Optional ZIP archive upload.
        /// </param>
        /// <param name="zip">
        /// Optional ZIP archive upload alias.
        /// </param>
        /// <param name="zipname">
        /// Optional ZIP archive upload alias.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSkillCollectionMultipartRequest(
            string? metadata,
            string? json,
            byte[]? archive,
            string? archivename,
            byte[]? zip,
            string? zipname)
        {
            this.Metadata = metadata;
            this.Json = json;
            this.Archive = archive;
            this.Archivename = archivename;
            this.Zip = zip;
            this.Zipname = zipname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillCollectionMultipartRequest" /> class.
        /// </summary>
        public CreateSkillCollectionMultipartRequest()
        {
        }
    }
}