
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Bucket-interval metadata describing how the time-series was bucketed.
    /// </summary>
    public sealed partial class RequestAnalyticsResponseChartInterval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        public string? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketSizeMs")]
        public int? BucketSizeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketMinutes")]
        public int? BucketMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseChartInterval" /> class.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="bucketSizeMs"></param>
        /// <param name="bucketMinutes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsResponseChartInterval(
            string? interval,
            int? bucketSizeMs,
            int? bucketMinutes)
        {
            this.Interval = interval;
            this.BucketSizeMs = bucketSizeMs;
            this.BucketMinutes = bucketMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponseChartInterval" /> class.
        /// </summary>
        public RequestAnalyticsResponseChartInterval()
        {
        }

    }
}