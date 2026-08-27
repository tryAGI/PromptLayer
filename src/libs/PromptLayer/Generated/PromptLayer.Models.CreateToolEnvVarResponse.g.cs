
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateToolEnvVarResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_env_var")]
        public global::PromptLayer.CreateToolEnvVarResponseToolEnvVar? ToolEnvVar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolEnvVarResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="toolEnvVar"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolEnvVarResponse(
            bool? success,
            global::PromptLayer.CreateToolEnvVarResponseToolEnvVar? toolEnvVar)
        {
            this.Success = success;
            this.ToolEnvVar = toolEnvVar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolEnvVarResponse" /> class.
        /// </summary>
        public CreateToolEnvVarResponse()
        {
        }

    }
}