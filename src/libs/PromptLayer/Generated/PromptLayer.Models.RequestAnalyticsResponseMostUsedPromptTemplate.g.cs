
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestAnalyticsResponseMostUsedPromptTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptId")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptName")]
        public string? PromptName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseMostUsedPromptTemplate" /> class.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="requests"></param>
        /// <param name="promptName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsResponseMostUsedPromptTemplate(
            string? promptId,
            int? requests,
            string? promptName)
        {
            this.PromptId = promptId;
            this.Requests = requests;
            this.PromptName = promptName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseMostUsedPromptTemplate" /> class.
        /// </summary>
        public RequestAnalyticsResponseMostUsedPromptTemplate()
        {
        }

    }
}