
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Resolved version object — includes `tool_definition` and (if set) `execution: { type, language, code }`.
    /// </summary>
    public sealed partial class GetToolRegistryResponseToolRegistryVersion
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}