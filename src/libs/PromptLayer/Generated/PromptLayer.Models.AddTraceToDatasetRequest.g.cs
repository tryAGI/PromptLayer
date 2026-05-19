
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTraceToDatasetRequest
    {
        /// <summary>
        /// ID of the dataset group to add the trace row to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// ID of the trace to add as a dataset row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// Optional span ID. When omitted the row anchors on the trace's earliest root span (Trace export). When provided the row anchors on that span and its direct children become the columns (Span export).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTraceToDatasetRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group to add the trace row to.
        /// </param>
        /// <param name="traceId">
        /// ID of the trace to add as a dataset row.
        /// </param>
        /// <param name="spanId">
        /// Optional span ID. When omitted the row anchors on the trace's earliest root span (Trace export). When provided the row anchors on that span and its direct children become the columns (Span export).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTraceToDatasetRequest(
            int datasetGroupId,
            string traceId,
            string? spanId)
        {
            this.DatasetGroupId = datasetGroupId;
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.SpanId = spanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTraceToDatasetRequest" /> class.
        /// </summary>
        public AddTraceToDatasetRequest()
        {
        }

    }
}