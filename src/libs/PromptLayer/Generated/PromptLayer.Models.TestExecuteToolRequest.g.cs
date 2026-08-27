
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestExecuteToolRequest
    {
        /// <summary>
        /// Arguments passed to the tool body. Same shape the LLM would emit — keys match the tool's parameter names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// In-flight override of the stored execution config. Lets you test unsaved code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        public global::PromptLayer.TestExecuteToolRequestExecution? Execution { get; set; }

        /// <summary>
        /// In-flight override of the stored tool definition. Used to test against a different function name without saving.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_definition")]
        public object? ToolDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestExecuteToolRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Arguments passed to the tool body. Same shape the LLM would emit — keys match the tool's parameter names.
        /// </param>
        /// <param name="execution">
        /// In-flight override of the stored execution config. Lets you test unsaved code.
        /// </param>
        /// <param name="toolDefinition">
        /// In-flight override of the stored tool definition. Used to test against a different function name without saving.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestExecuteToolRequest(
            object? inputs,
            global::PromptLayer.TestExecuteToolRequestExecution? execution,
            object? toolDefinition)
        {
            this.Inputs = inputs;
            this.Execution = execution;
            this.ToolDefinition = toolDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestExecuteToolRequest" /> class.
        /// </summary>
        public TestExecuteToolRequest()
        {
        }

    }
}