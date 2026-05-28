
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToolVersionRequest
    {
        /// <summary>
        /// Tool definition in OpenAI function-calling format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ToolDefinition { get; set; }

        /// <summary>
        /// Optional sandbox-executable body. When set, PromptLayer auto-runs the body between LLM turns whenever a prompt uses this version. See Auto Tool Execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        public global::PromptLayer.CreateToolVersionRequestExecution? Execution { get; set; }

        /// <summary>
        /// Commit message for the new version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolVersionRequest" /> class.
        /// </summary>
        /// <param name="toolDefinition">
        /// Tool definition in OpenAI function-calling format
        /// </param>
        /// <param name="execution">
        /// Optional sandbox-executable body. When set, PromptLayer auto-runs the body between LLM turns whenever a prompt uses this version. See Auto Tool Execution.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for the new version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolVersionRequest(
            object toolDefinition,
            global::PromptLayer.CreateToolVersionRequestExecution? execution,
            string? commitMessage)
        {
            this.ToolDefinition = toolDefinition ?? throw new global::System.ArgumentNullException(nameof(toolDefinition));
            this.Execution = execution;
            this.CommitMessage = commitMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolVersionRequest" /> class.
        /// </summary>
        public CreateToolVersionRequest()
        {
        }

    }
}