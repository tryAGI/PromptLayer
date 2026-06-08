
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Create multiple observability spans in a single request. Each span may include log_request to create an associated request log.
    /// </summary>
    public sealed partial class CreateSpansBulk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.Span> Spans { get; set; }

        /// <summary>
        /// When true, all trace IDs in this batch are marked as closed after the spans are persisted. Subsequent span writes for those traces will be rejected with a trace_closed rejection reason. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close_after")]
        public bool? CloseAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulk" /> class.
        /// </summary>
        /// <param name="spans"></param>
        /// <param name="closeAfter">
        /// When true, all trace IDs in this batch are marked as closed after the spans are persisted. Subsequent span writes for those traces will be rejected with a trace_closed rejection reason. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpansBulk(
            global::System.Collections.Generic.IList<global::PromptLayer.Span> spans,
            bool? closeAfter)
        {
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
            this.CloseAfter = closeAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulk" /> class.
        /// </summary>
        public CreateSpansBulk()
        {
        }

    }
}