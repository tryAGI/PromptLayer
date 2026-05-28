
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasePromptTemplate
    {
        /// <summary>
        /// The unique prompt name within the workspace. 1-512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptName { get; set; }

        /// <summary>
        /// Tags to attach to the prompt registry entry.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The ID of the folder to publish the prompt template into. If omitted, the prompt is created at the workspace root. Use Resolve Folder ID by Path to look up an ID from a path, or Create Folder to make one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Optional workspace override; defaults to the workspace associated with the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePromptTemplate" /> class.
        /// </summary>
        /// <param name="promptName">
        /// The unique prompt name within the workspace. 1-512 characters.
        /// </param>
        /// <param name="tags">
        /// Tags to attach to the prompt registry entry.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="folderId">
        /// The ID of the folder to publish the prompt template into. If omitted, the prompt is created at the workspace root. Use Resolve Folder ID by Path to look up an ID from a path, or Create Folder to make one.
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace override; defaults to the workspace associated with the API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasePromptTemplate(
            string promptName,
            global::System.Collections.Generic.IList<string>? tags,
            int? folderId,
            int? workspaceId)
        {
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.Tags = tags;
            this.FolderId = folderId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePromptTemplate" /> class.
        /// </summary>
        public BasePromptTemplate()
        {
        }

    }
}