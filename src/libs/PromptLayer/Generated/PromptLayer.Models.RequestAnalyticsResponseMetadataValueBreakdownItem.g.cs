
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestAnalyticsResponseMetadataValueBreakdownItem
    {
        /// <summary>
        /// The metadata key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The metadata value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Display label. Equals `value` when filtered to a single key; equals `key = value` in the aggregate view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Number of requests with this key-value pair.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Total cost for requests with this key-value pair, in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseMetadataValueBreakdownItem" /> class.
        /// </summary>
        /// <param name="key">
        /// The metadata key.
        /// </param>
        /// <param name="value">
        /// The metadata value.
        /// </param>
        /// <param name="label">
        /// Display label. Equals `value` when filtered to a single key; equals `key = value` in the aggregate view.
        /// </param>
        /// <param name="requests">
        /// Number of requests with this key-value pair.
        /// </param>
        /// <param name="cost">
        /// Total cost for requests with this key-value pair, in USD.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsResponseMetadataValueBreakdownItem(
            string? key,
            string? value,
            string? label,
            int? requests,
            double? cost)
        {
            this.Key = key;
            this.Value = value;
            this.Label = label;
            this.Requests = requests;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseMetadataValueBreakdownItem" /> class.
        /// </summary>
        public RequestAnalyticsResponseMetadataValueBreakdownItem()
        {
        }

    }
}