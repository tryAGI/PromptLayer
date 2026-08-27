
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListWorkspaceEnvVarsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_env_vars")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ListWorkspaceEnvVarsResponseWorkspaceEnvVar>? WorkspaceEnvVars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspaceEnvVarsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="workspaceEnvVars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorkspaceEnvVarsResponse(
            bool? success,
            global::System.Collections.Generic.IList<global::PromptLayer.ListWorkspaceEnvVarsResponseWorkspaceEnvVar>? workspaceEnvVars)
        {
            this.Success = success;
            this.WorkspaceEnvVars = workspaceEnvVars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspaceEnvVarsResponse" /> class.
        /// </summary>
        public ListWorkspaceEnvVarsResponse()
        {
        }

    }
}