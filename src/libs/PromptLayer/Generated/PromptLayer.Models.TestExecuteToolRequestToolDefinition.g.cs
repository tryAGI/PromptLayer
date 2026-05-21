
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// In-flight override of the stored tool definition. Used to test against a different function name without saving.
    /// </summary>
    public sealed partial class TestExecuteToolRequestToolDefinition
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}