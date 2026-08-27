
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestLogSearchResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        public string? Engine { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        public string? ProviderType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_start_time")]
        public global::System.DateTime? RequestStartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_end_time")]
        public global::System.DateTime? RequestEndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_array")]
        public global::System.Collections.Generic.IList<string>? TagsArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<object>? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.IList<object>? Scores { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        public string? PromptName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogSearchResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="engine"></param>
        /// <param name="providerType"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="price"></param>
        /// <param name="requestStartTime"></param>
        /// <param name="requestEndTime"></param>
        /// <param name="latency"></param>
        /// <param name="tagsArray"></param>
        /// <param name="metadata"></param>
        /// <param name="scores"></param>
        /// <param name="promptName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestLogSearchResult(
            int? id,
            string? engine,
            string? providerType,
            int? inputTokens,
            int? outputTokens,
            double? price,
            global::System.DateTime? requestStartTime,
            global::System.DateTime? requestEndTime,
            double? latency,
            global::System.Collections.Generic.IList<string>? tagsArray,
            global::System.Collections.Generic.IList<object>? metadata,
            global::System.Collections.Generic.IList<object>? scores,
            string? promptName)
        {
            this.Id = id;
            this.Engine = engine;
            this.ProviderType = providerType;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Price = price;
            this.RequestStartTime = requestStartTime;
            this.RequestEndTime = requestEndTime;
            this.Latency = latency;
            this.TagsArray = tagsArray;
            this.Metadata = metadata;
            this.Scores = scores;
            this.PromptName = promptName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogSearchResult" /> class.
        /// </summary>
        public RequestLogSearchResult()
        {
        }

    }
}