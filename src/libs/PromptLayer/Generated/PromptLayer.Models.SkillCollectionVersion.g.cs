
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// A saved version of a skill collection.
    /// </summary>
    public sealed partial class SkillCollectionVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_collection_id")]
        public global::System.Guid? SkillCollectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_path_at_version")]
        public string? RootPathAtVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_paths")]
        public global::System.Collections.Generic.IList<string>? FilePaths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_label")]
        public string? ReleaseLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillCollectionVersion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="skillCollectionId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="number"></param>
        /// <param name="rootPathAtVersion"></param>
        /// <param name="provider"></param>
        /// <param name="filePaths"></param>
        /// <param name="commitMessage"></param>
        /// <param name="releaseLabel"></param>
        /// <param name="archived"></param>
        /// <param name="createdBy"></param>
        /// <param name="userEmail"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillCollectionVersion(
            global::System.Guid? id,
            global::System.Guid? skillCollectionId,
            int? workspaceId,
            int? number,
            string? rootPathAtVersion,
            string? provider,
            global::System.Collections.Generic.IList<string>? filePaths,
            string? commitMessage,
            string? releaseLabel,
            bool? archived,
            int? createdBy,
            string? userEmail,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.SkillCollectionId = skillCollectionId;
            this.WorkspaceId = workspaceId;
            this.Number = number;
            this.RootPathAtVersion = rootPathAtVersion;
            this.Provider = provider;
            this.FilePaths = filePaths;
            this.CommitMessage = commitMessage;
            this.ReleaseLabel = releaseLabel;
            this.Archived = archived;
            this.CreatedBy = createdBy;
            this.UserEmail = userEmail;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillCollectionVersion" /> class.
        /// </summary>
        public SkillCollectionVersion()
        {
        }
    }
}