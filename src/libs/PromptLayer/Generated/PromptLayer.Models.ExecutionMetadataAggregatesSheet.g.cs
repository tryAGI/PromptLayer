
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Sheet-wide aggregates rolled up across all prompt-template columns.
    /// </summary>
    public sealed partial class ExecutionMetadataAggregatesSheet
    {
        /// <summary>
        /// Aggregates keyed by metric key (`price`, `latency_ms`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::PromptLayer.ExecutionMetadataMetricAggregate> ByMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionMetadataAggregatesSheet" /> class.
        /// </summary>
        /// <param name="byMetric">
        /// Aggregates keyed by metric key (`price`, `latency_ms`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionMetadataAggregatesSheet(
            global::System.Collections.Generic.Dictionary<string, global::PromptLayer.ExecutionMetadataMetricAggregate> byMetric)
        {
            this.ByMetric = byMetric ?? throw new global::System.ArgumentNullException(nameof(byMetric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionMetadataAggregatesSheet" /> class.
        /// </summary>
        public ExecutionMetadataAggregatesSheet()
        {
        }

    }
}