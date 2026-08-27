
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListPromptTemplateItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.PromptTemplate6JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.PromptTemplate6 PromptTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::PromptLayer.Metadata? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// When you optionally specify `provider` in the body, `llm_kwargs` will be returned for that specific provider and you can pass these kwargs to the provider's API directly. **Important:** This object's structure is provider-specific and may change without notice as LLM providers update their APIs. For stable, provider-agnostic prompt data, use `prompt_template` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_kwargs")]
        public object? LlmKwargs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// External ID mappings attached to the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.ExternalId> ExternalIds { get; set; }

        /// <summary>
        /// Whether this prompt template record is a snippet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_snippet")]
        public bool? IsSnippet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromptTemplateItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptName"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="externalIds">
        /// External ID mappings attached to the prompt template.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="commitMessage"></param>
        /// <param name="llmKwargs">
        /// When you optionally specify `provider` in the body, `llm_kwargs` will be returned for that specific provider and you can pass these kwargs to the provider's API directly. **Important:** This object's structure is provider-specific and may change without notice as LLM providers update their APIs. For stable, provider-agnostic prompt data, use `prompt_template` instead.
        /// </param>
        /// <param name="version"></param>
        /// <param name="isSnippet">
        /// Whether this prompt template record is a snippet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPromptTemplateItem(
            int id,
            string promptName,
            global::PromptLayer.PromptTemplate6 promptTemplate,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId> externalIds,
            global::PromptLayer.Metadata? metadata,
            string? commitMessage,
            object? llmKwargs,
            int? version,
            bool? isSnippet)
        {
            this.Id = id;
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.PromptTemplate = promptTemplate;
            this.Metadata = metadata;
            this.CommitMessage = commitMessage;
            this.LlmKwargs = llmKwargs;
            this.Version = version;
            this.ExternalIds = externalIds ?? throw new global::System.ArgumentNullException(nameof(externalIds));
            this.IsSnippet = isSnippet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromptTemplateItem" /> class.
        /// </summary>
        public ListPromptTemplateItem()
        {
        }

    }
}