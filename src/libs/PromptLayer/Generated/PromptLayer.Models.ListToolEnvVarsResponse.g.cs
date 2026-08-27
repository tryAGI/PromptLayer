
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListToolEnvVarsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_env_vars")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ListToolEnvVarsResponseToolEnvVar>? ToolEnvVars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolEnvVarsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="toolEnvVars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListToolEnvVarsResponse(
            bool? success,
            global::System.Collections.Generic.IList<global::PromptLayer.ListToolEnvVarsResponseToolEnvVar>? toolEnvVars)
        {
            this.Success = success;
            this.ToolEnvVars = toolEnvVars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolEnvVarsResponse" /> class.
        /// </summary>
        public ListToolEnvVarsResponse()
        {
        }

    }
}