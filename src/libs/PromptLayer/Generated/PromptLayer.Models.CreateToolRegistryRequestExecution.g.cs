
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Optional sandbox-executable body for the tool. When set, PromptLayer auto-runs the body between LLM turns. See the Auto Tool Execution feature page.
    /// </summary>
    public sealed partial class CreateToolRegistryRequestExecution
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionTypeJsonConverter))]
        public global::PromptLayer.CreateToolRegistryRequestExecutionType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.CreateToolRegistryRequestExecutionLanguage Language { get; set; }

        /// <summary>
        /// The function BODY only — the signature `def &lt;name&gt;(args):` (Python) or `function &lt;name&gt;(args) { ... }` (JavaScript) is generated automatically. The LLM's arguments arrive as a single `args` object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolRegistryRequestExecution" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="code">
        /// The function BODY only — the signature `def &lt;name&gt;(args):` (Python) or `function &lt;name&gt;(args) { ... }` (JavaScript) is generated automatically. The LLM's arguments arrive as a single `args` object.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolRegistryRequestExecution(
            global::PromptLayer.CreateToolRegistryRequestExecutionLanguage language,
            string code,
            global::PromptLayer.CreateToolRegistryRequestExecutionType type)
        {
            this.Type = type;
            this.Language = language;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolRegistryRequestExecution" /> class.
        /// </summary>
        public CreateToolRegistryRequestExecution()
        {
        }

    }
}