
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Provider-specific LLM arguments. Only present when include_llm_kwargs=true. Structure is provider-specific and may change without notice.
    /// </summary>
    public sealed partial class GetPromptTemplateRawResponseLlmKwargs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}