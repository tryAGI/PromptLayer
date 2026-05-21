
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Arguments passed to the tool body. Same shape the LLM would emit — keys match the tool's parameter names.
    /// </summary>
    public sealed partial class TestExecuteToolRequestInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}