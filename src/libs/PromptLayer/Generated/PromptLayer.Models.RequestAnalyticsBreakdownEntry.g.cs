
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Aggregated breakdown row (provider / prompt / tag).
    /// </summary>
    public sealed partial class RequestAnalyticsBreakdownEntry
    {
        /// <summary>
        /// Set on provider breakdown rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Set on prompt breakdown rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptId")]
        public string? PromptId { get; set; }

        /// <summary>
        /// Set on tag breakdown rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public int? Tokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputTokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsBreakdownEntry" /> class.
        /// </summary>
        /// <param name="provider">
        /// Set on provider breakdown rows.
        /// </param>
        /// <param name="promptId">
        /// Set on prompt breakdown rows.
        /// </param>
        /// <param name="tag">
        /// Set on tag breakdown rows.
        /// </param>
        /// <param name="requests"></param>
        /// <param name="cost"></param>
        /// <param name="tokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsBreakdownEntry(
            string? provider,
            string? promptId,
            string? tag,
            int? requests,
            double? cost,
            int? tokens,
            int? inputTokens,
            int? outputTokens)
        {
            this.Provider = provider;
            this.PromptId = promptId;
            this.Tag = tag;
            this.Requests = requests;
            this.Cost = cost;
            this.Tokens = tokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsBreakdownEntry" /> class.
        /// </summary>
        public RequestAnalyticsBreakdownEntry()
        {
        }

    }
}