
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Optional sandbox-executable body. When set, PromptLayer auto-runs the body between LLM turns whenever a prompt uses this version. See Auto Tool Execution.
    /// </summary>
    public sealed partial class CreateToolVersionRequestExecution
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionTypeJsonConverter))]
        public global::PromptLayer.CreateToolVersionRequestExecutionType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.CreateToolVersionRequestExecutionLanguage Language { get; set; }

        /// <summary>
        /// The function BODY only — the signature `def &lt;name&gt;(args):` (Python) or `function &lt;name&gt;(args) { ... }` (JavaScript) is generated automatically. LLM arguments arrive as a single `args` object.
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
        /// Initializes a new instance of the <see cref="CreateToolVersionRequestExecution" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="code">
        /// The function BODY only — the signature `def &lt;name&gt;(args):` (Python) or `function &lt;name&gt;(args) { ... }` (JavaScript) is generated automatically. LLM arguments arrive as a single `args` object.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolVersionRequestExecution(
            global::PromptLayer.CreateToolVersionRequestExecutionLanguage language,
            string code,
            global::PromptLayer.CreateToolVersionRequestExecutionType type)
        {
            this.Type = type;
            this.Language = language;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolVersionRequestExecution" /> class.
        /// </summary>
        public CreateToolVersionRequestExecution()
        {
        }

    }
}