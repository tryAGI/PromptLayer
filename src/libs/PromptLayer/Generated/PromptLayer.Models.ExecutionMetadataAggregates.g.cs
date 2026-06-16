
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Sheet-level and per-column aggregates for execution metrics (price and latency) across all prompt-template columns.
    /// </summary>
    public sealed partial class ExecutionMetadataAggregates
    {
        /// <summary>
        /// Per-column aggregates keyed by the system-managed metadata column ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_column_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::PromptLayer.ExecutionMetadataMetricAggregate> ByColumnId { get; set; }

        /// <summary>
        /// Sheet-wide aggregates rolled up across all prompt-template columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.ExecutionMetadataAggregatesSheet Sheet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionMetadataAggregates" /> class.
        /// </summary>
        /// <param name="byColumnId">
        /// Per-column aggregates keyed by the system-managed metadata column ID.
        /// </param>
        /// <param name="sheet">
        /// Sheet-wide aggregates rolled up across all prompt-template columns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionMetadataAggregates(
            global::System.Collections.Generic.Dictionary<string, global::PromptLayer.ExecutionMetadataMetricAggregate> byColumnId,
            global::PromptLayer.ExecutionMetadataAggregatesSheet sheet)
        {
            this.ByColumnId = byColumnId ?? throw new global::System.ArgumentNullException(nameof(byColumnId));
            this.Sheet = sheet ?? throw new global::System.ArgumentNullException(nameof(sheet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionMetadataAggregates" /> class.
        /// </summary>
        public ExecutionMetadataAggregates()
        {
        }

    }
}