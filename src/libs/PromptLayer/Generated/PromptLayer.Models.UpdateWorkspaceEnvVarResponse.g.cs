
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWorkspaceEnvVarResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_env_var")]
        public global::PromptLayer.UpdateWorkspaceEnvVarResponseWorkspaceEnvVar? WorkspaceEnvVar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkspaceEnvVarResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="workspaceEnvVar"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWorkspaceEnvVarResponse(
            bool? success,
            global::PromptLayer.UpdateWorkspaceEnvVarResponseWorkspaceEnvVar? workspaceEnvVar)
        {
            this.Success = success;
            this.WorkspaceEnvVar = workspaceEnvVar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkspaceEnvVarResponse" /> class.
        /// </summary>
        public UpdateWorkspaceEnvVarResponse()
        {
        }

    }
}