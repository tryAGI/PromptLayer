
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersion
    {
        /// <summary>
        /// The prompt content, either chat or completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.PromptTemplate3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.PromptTemplate3 PromptTemplate { get; set; }

        /// <summary>
        /// Message describing the changes in this version. Maximum 72 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Metadata to attach to the prompt version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::PromptLayer.Metadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersion" /> class.
        /// </summary>
        /// <param name="promptTemplate">
        /// The prompt content, either chat or completion.
        /// </param>
        /// <param name="commitMessage">
        /// Message describing the changes in this version. Maximum 72 characters.
        /// </param>
        /// <param name="metadata">
        /// Metadata to attach to the prompt version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersion(
            global::PromptLayer.PromptTemplate3 promptTemplate,
            string? commitMessage,
            global::PromptLayer.Metadata? metadata)
        {
            this.PromptTemplate = promptTemplate;
            this.CommitMessage = commitMessage;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersion" /> class.
        /// </summary>
        public PromptVersion()
        {
        }
    }
}