
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListToolRegistriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_registries")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ListToolRegistriesResponseToolRegistrie>? ToolRegistries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolRegistriesResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="toolRegistries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListToolRegistriesResponse(
            bool? success,
            global::System.Collections.Generic.IList<global::PromptLayer.ListToolRegistriesResponseToolRegistrie>? toolRegistries)
        {
            this.Success = success;
            this.ToolRegistries = toolRegistries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolRegistriesResponse" /> class.
        /// </summary>
        public ListToolRegistriesResponse()
        {
        }

    }
}