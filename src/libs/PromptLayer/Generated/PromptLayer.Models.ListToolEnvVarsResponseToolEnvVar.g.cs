
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListToolEnvVarsResponseToolEnvVar
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Last 4 characters of the stored value. Null or empty when the value is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_suffix")]
        public string? ValueSuffix { get; set; }

        /// <summary>
        /// True when the value has not been set yet (placeholder created by the AI assistant).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_empty")]
        public bool? IsEmpty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Present on workspace-scoped env vars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Present on tool-scoped env vars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_registry_id")]
        public int? ToolRegistryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolEnvVarsResponseToolEnvVar" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="valueSuffix">
        /// Last 4 characters of the stored value. Null or empty when the value is empty.
        /// </param>
        /// <param name="isEmpty">
        /// True when the value has not been set yet (placeholder created by the AI assistant).
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="workspaceId">
        /// Present on workspace-scoped env vars.
        /// </param>
        /// <param name="toolRegistryId">
        /// Present on tool-scoped env vars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListToolEnvVarsResponseToolEnvVar(
            int? id,
            string? key,
            string? valueSuffix,
            bool? isEmpty,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? workspaceId,
            int? toolRegistryId)
        {
            this.Id = id;
            this.Key = key;
            this.ValueSuffix = valueSuffix;
            this.IsEmpty = isEmpty;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.WorkspaceId = workspaceId;
            this.ToolRegistryId = toolRegistryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolEnvVarsResponseToolEnvVar" /> class.
        /// </summary>
        public ListToolEnvVarsResponseToolEnvVar()
        {
        }

    }
}