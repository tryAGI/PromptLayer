
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateToolRegistryRequest
    {
        /// <summary>
        /// Tool name (unique per workspace)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tool definition in OpenAI function-calling format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ToolDefinition { get; set; }

        /// <summary>
        /// Optional human-readable description of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Folder ID to place tool in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Commit message for the initial version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Identifiers from other systems.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? ExternalIds { get; set; }

        /// <summary>
        /// Optional sandbox-executable body for the tool. When set, PromptLayer auto-runs the body between LLM turns. See the Auto Tool Execution feature page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        public global::PromptLayer.CreateToolRegistryRequestExecution? Execution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolRegistryRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Tool name (unique per workspace)
        /// </param>
        /// <param name="toolDefinition">
        /// Tool definition in OpenAI function-calling format
        /// </param>
        /// <param name="description">
        /// Optional human-readable description of the tool
        /// </param>
        /// <param name="folderId">
        /// Folder ID to place tool in
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for the initial version
        /// </param>
        /// <param name="externalIds">
        /// Identifiers from other systems.
        /// </param>
        /// <param name="execution">
        /// Optional sandbox-executable body for the tool. When set, PromptLayer auto-runs the body between LLM turns. See the Auto Tool Execution feature page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolRegistryRequest(
            string name,
            object toolDefinition,
            string? description,
            int? folderId,
            string? commitMessage,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds,
            global::PromptLayer.CreateToolRegistryRequestExecution? execution)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ToolDefinition = toolDefinition ?? throw new global::System.ArgumentNullException(nameof(toolDefinition));
            this.Description = description;
            this.FolderId = folderId;
            this.CommitMessage = commitMessage;
            this.ExternalIds = externalIds;
            this.Execution = execution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolRegistryRequest" /> class.
        /// </summary>
        public CreateToolRegistryRequest()
        {
        }

    }
}