
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSkillCollectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::PromptLayer.InitialFileUpdate>? Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillCollectionRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="folderId"></param>
        /// <param name="provider"></param>
        /// <param name="files">
        /// Default Value: []
        /// </param>
        /// <param name="commitMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSkillCollectionRequest(
            string name,
            int? folderId,
            string? provider,
            global::System.Collections.Generic.IList<global::PromptLayer.InitialFileUpdate>? files,
            string? commitMessage)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FolderId = folderId;
            this.Provider = provider;
            this.Files = files;
            this.CommitMessage = commitMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillCollectionRequest" /> class.
        /// </summary>
        public CreateSkillCollectionRequest()
        {
        }
    }
}