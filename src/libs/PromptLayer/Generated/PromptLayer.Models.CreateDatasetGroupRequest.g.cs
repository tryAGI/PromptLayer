
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetGroupRequest
    {
        /// <summary>
        /// Name of the dataset group. Must be unique within the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional: ID of the workspace where the dataset group will be created. If not provided, uses the workspace associated with your API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Optional folder ID to create the dataset group inside. If omitted, the dataset group is created at the workspace root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Identifiers from other systems.
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
        /// Name of the dataset group. Must be unique within the workspace.
        /// </param>
        /// <param name="workspaceId">
        /// Optional: ID of the workspace where the dataset group will be created. If not provided, uses the workspace associated with your API key.
        /// </param>
        /// <param name="folderId">
        /// Optional folder ID to create the dataset group inside. If omitted, the dataset group is created at the workspace root.
        /// </param>
        /// <param name="externalIds">
        /// Identifiers from other systems.
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