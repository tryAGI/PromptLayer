
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestAnalyticsResponseMetadataKeysTopItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

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
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseMetadataKeysTopItem" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="requests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsResponseMetadataKeysTopItem(
            string? key,
            int? requests)
        {
            this.Key = key;
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseMetadataKeysTopItem" /> class.
        /// </summary>
        public RequestAnalyticsResponseMetadataKeysTopItem()
        {
        }

    }
}