
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDatasetGroupRequest
    {
        /// <summary>
        /// Name for the dataset group. Must be unique within the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Workspace ID. Defaults to the workspace associated with the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Folder ID to create the dataset group in. Omit to create at the workspace root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// External ID mappings to attach to the dataset group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? ExternalIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetGroupRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the dataset group. Must be unique within the workspace.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID. Defaults to the workspace associated with the API key.
        /// </param>
        /// <param name="folderId">
        /// Folder ID to create the dataset group in. Omit to create at the workspace root.
        /// </param>
        /// <param name="externalIds">
        /// External ID mappings to attach to the dataset group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetGroupRequest(
            string name,
            int? workspaceId,
            int? folderId,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WorkspaceId = workspaceId;
            this.FolderId = folderId;
            this.ExternalIds = externalIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetGroupRequest" /> class.
        /// </summary>
        public CreateDatasetGroupRequest()
        {
        }

    }
}