
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestAnalyticsStatOutputShapeCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public int? Json { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCall")]
        public int? ToolCall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plainText")]
        public int? PlainText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsStatOutputShapeCounts" /> class.
        /// </summary>
        /// <param name="json"></param>
        /// <param name="toolCall"></param>
        /// <param name="plainText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsStatOutputShapeCounts(
            int? json,
            int? toolCall,
            int? plainText)
        {
            this.Json = json;
            this.ToolCall = toolCall;
            this.PlainText = plainText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsStatOutputShapeCounts" /> class.
        /// </summary>
        public RequestAnalyticsStatOutputShapeCounts()
        {
        }

    }
}