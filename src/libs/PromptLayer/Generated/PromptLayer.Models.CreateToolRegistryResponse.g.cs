
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToolRegistryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_registry")]
        public object? ToolRegistry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public object? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolRegistryResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="toolRegistry"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolRegistryResponse(
            bool? success,
            object? toolRegistry,
            object? version)
        {
            this.Success = success;
            this.ToolRegistry = toolRegistry;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolRegistryResponse" /> class.
        /// </summary>
        public CreateToolRegistryResponse()
        {
        }
    }
}