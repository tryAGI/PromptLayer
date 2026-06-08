
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Aggregated statistics for a single execution metric (e.g. price or latency) across all rows in a sheet.
    /// </summary>
    public sealed partial class ExecutionMetadataMetricAggregate
    {
        /// <summary>
        /// Internal metric identifier. One of `price` or `latency_ms`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey MetricKey { get; set; }

        /// <summary>
        /// Human-readable label for the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_label")]
        public string? MetricLabel { get; set; }

        /// <summary>
        /// Number of rows that have a value for this metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Sum of all metric values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sum { get; set; }

        /// <summary>
        /// Average metric value, or null if count is 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        public double? Avg { get; set; }

        /// <summary>
        /// Minimum metric value, or null if count is 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Maximum metric value, or null if count is 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// ID of the system-managed metadata column for this metric. Omitted for sheet-level aggregates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        public global::System.Guid? ColumnId { get; set; }

        /// <summary>
        /// ID of the prompt-template source column. Omitted for sheet-level aggregates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_column_id")]
        public global::System.Guid? SourceColumnId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionMetadataMetricAggregate" /> class.
        /// </summary>
        /// <param name="metricKey">
        /// Internal metric identifier. One of `price` or `latency_ms`.
        /// </param>
        /// <param name="count">
        /// Number of rows that have a value for this metric.
        /// </param>
        /// <param name="sum">
        /// Sum of all metric values.
        /// </param>
        /// <param name="metricLabel">
        /// Human-readable label for the metric.
        /// </param>
        /// <param name="avg">
        /// Average metric value, or null if count is 0.
        /// </param>
        /// <param name="min">
        /// Minimum metric value, or null if count is 0.
        /// </param>
        /// <param name="max">
        /// Maximum metric value, or null if count is 0.
        /// </param>
        /// <param name="columnId">
        /// ID of the system-managed metadata column for this metric. Omitted for sheet-level aggregates.
        /// </param>
        /// <param name="sourceColumnId">
        /// ID of the prompt-template source column. Omitted for sheet-level aggregates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionMetadataMetricAggregate(
            global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey metricKey,
            int count,
            double sum,
            string? metricLabel,
            double? avg,
            double? min,
            double? max,
            global::System.Guid? columnId,
            global::System.Guid? sourceColumnId)
        {
            this.MetricKey = metricKey;
            this.MetricLabel = metricLabel;
            this.Count = count;
            this.Sum = sum;
            this.Avg = avg;
            this.Min = min;
            this.Max = max;
            this.ColumnId = columnId;
            this.SourceColumnId = sourceColumnId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionMetadataMetricAggregate" /> class.
        /// </summary>
        public ExecutionMetadataMetricAggregate()
        {
        }

    }
}