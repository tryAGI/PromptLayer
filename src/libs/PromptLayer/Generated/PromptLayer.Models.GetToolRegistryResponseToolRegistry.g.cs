
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRegistryResponseToolRegistry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<object>? Labels { get; set; }

        /// <summary>
        /// Resolved version object — includes `tool_definition` and (if set) `execution: { type, language, code }`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public object? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_definition")]
        public object? ToolDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRegistryResponseToolRegistry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="workspaceId"></param>
        /// <param name="labels"></param>
        /// <param name="version">
        /// Resolved version object — includes `tool_definition` and (if set) `execution: { type, language, code }`.
        /// </param>
        /// <param name="toolDefinition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRegistryResponseToolRegistry(
            int? id,
            string? name,
            string? description,
            int? workspaceId,
            global::System.Collections.Generic.IList<object>? labels,
            object? version,
            object? toolDefinition)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.WorkspaceId = workspaceId;
            this.Labels = labels;
            this.Version = version;
            this.ToolDefinition = toolDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRegistryResponseToolRegistry" /> class.
        /// </summary>
        public GetToolRegistryResponseToolRegistry()
        {
        }

    }
}