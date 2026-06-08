
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpansBulkResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Spans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_logs")]
        public global::System.Collections.Generic.IList<object>? RequestLogs { get; set; }

        /// <summary>
        /// Span IDs that were dropped because they belong to a closed trace. Only present when one or more spans were rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected_span_ids")]
        public global::System.Collections.Generic.IList<string>? RejectedSpanIds { get; set; }

        /// <summary>
        /// Trace IDs that were closed and caused span rejections. Only present when one or more spans were rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected_trace_ids")]
        public global::System.Collections.Generic.IList<string>? RejectedTraceIds { get; set; }

        /// <summary>
        /// The reason spans were rejected. Currently only `trace_closed` is possible. Only present when one or more spans were rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejection_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonJsonConverter))]
        public global::PromptLayer.CreateSpansBulkResponseRejectionReason? RejectionReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulkResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="spans"></param>
        /// <param name="requestLogs"></param>
        /// <param name="rejectedSpanIds">
        /// Span IDs that were dropped because they belong to a closed trace. Only present when one or more spans were rejected.
        /// </param>
        /// <param name="rejectedTraceIds">
        /// Trace IDs that were closed and caused span rejections. Only present when one or more spans were rejected.
        /// </param>
        /// <param name="rejectionReason">
        /// The reason spans were rejected. Currently only `trace_closed` is possible. Only present when one or more spans were rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpansBulkResponse(
            bool success,
            global::System.Collections.Generic.IList<object> spans,
            global::System.Collections.Generic.IList<object>? requestLogs,
            global::System.Collections.Generic.IList<string>? rejectedSpanIds,
            global::System.Collections.Generic.IList<string>? rejectedTraceIds,
            global::PromptLayer.CreateSpansBulkResponseRejectionReason? rejectionReason)
        {
            this.Success = success;
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
            this.RequestLogs = requestLogs;
            this.RejectedSpanIds = rejectedSpanIds;
            this.RejectedTraceIds = rejectedTraceIds;
            this.RejectionReason = rejectionReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulkResponse" /> class.
        /// </summary>
        public CreateSpansBulkResponse()
        {
        }

    }
}