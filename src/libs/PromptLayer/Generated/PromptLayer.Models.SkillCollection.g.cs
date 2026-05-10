
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// A skill collection container in the public API.
    /// </summary>
    public sealed partial class SkillCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_path")]
        public string? RootPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillCollection" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workspaceId"></param>
        /// <param name="folderId"></param>
        /// <param name="rootPath"></param>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="isDeleted"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillCollection(
            global::System.Guid? id,
            int? workspaceId,
            int? folderId,
            string? rootPath,
            string? name,
            string? provider,
            bool? isDeleted,
            int? createdBy,
            global::System.DateTime? createdAt,
            int? updatedBy,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.FolderId = folderId;
            this.RootPath = rootPath;
            this.Name = name;
            this.Provider = provider;
            this.IsDeleted = isDeleted;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.UpdatedBy = updatedBy;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillCollection" /> class.
        /// </summary>
        public SkillCollection()
        {
        }

    }
}