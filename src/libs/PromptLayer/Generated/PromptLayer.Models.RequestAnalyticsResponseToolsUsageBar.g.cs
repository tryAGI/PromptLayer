
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestAnalyticsResponseToolsUsageBar
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseToolsUsageBar" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsResponseToolsUsageBar(
            string? name,
            int? requests)
        {
            this.Name = name;
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseToolsUsageBar" /> class.
        /// </summary>
        public RequestAnalyticsResponseToolsUsageBar()
        {
        }
    }
}