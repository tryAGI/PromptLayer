
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackPromptRequest
    {
        /// <summary>
        /// Prompt template name to associate with the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptName { get; set; }

        /// <summary>
        /// Variables used to render the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_input_variables")]
        public object? PromptInputVariables { get; set; }

        /// <summary>
        /// PromptLayer request ID to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.AnyOf<int?, string> RequestId { get; set; }

        /// <summary>
        /// Prompt template version to associate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string, object>))]
        public global::PromptLayer.AnyOf<int?, string, object>? Version { get; set; }

        /// <summary>
        /// Release label to resolve to a prompt template version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackPromptRequest" /> class.
        /// </summary>
        /// <param name="promptName">
        /// Prompt template name to associate with the request.
        /// </param>
        /// <param name="requestId">
        /// PromptLayer request ID to update.
        /// </param>
        /// <param name="promptInputVariables">
        /// Variables used to render the prompt.
        /// </param>
        /// <param name="version">
        /// Prompt template version to associate.
        /// </param>
        /// <param name="label">
        /// Release label to resolve to a prompt template version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackPromptRequest(
            string promptName,
            global::PromptLayer.AnyOf<int?, string> requestId,
            object? promptInputVariables,
            global::PromptLayer.AnyOf<int?, string, object>? version,
            string? label)
        {
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.PromptInputVariables = promptInputVariables;
            this.RequestId = requestId;
            this.Version = version;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackPromptRequest" /> class.
        /// </summary>
        public TrackPromptRequest()
        {
        }

    }
}