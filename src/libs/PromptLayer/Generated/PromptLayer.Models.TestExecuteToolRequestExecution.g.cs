
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// In-flight override of the stored execution config. Lets you test unsaved code.
    /// </summary>
    public sealed partial class TestExecuteToolRequestExecution
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionTypeJsonConverter))]
        public global::PromptLayer.TestExecuteToolRequestExecutionType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TestExecuteToolRequestExecutionLanguage Language { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="TestExecuteToolRequestExecution" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="code"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestExecuteToolRequestExecution(
            global::PromptLayer.TestExecuteToolRequestExecutionLanguage language,
            string code,
            global::PromptLayer.TestExecuteToolRequestExecutionType type)
        {
            this.Type = type;
            this.Language = language;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestExecuteToolRequestExecution" /> class.
        /// </summary>
        public TestExecuteToolRequestExecution()
        {
        }

    }
}