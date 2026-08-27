
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IngestOtlpTracesResponse2
    {
        /// <summary>
        /// Example: Trace already closed: a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6
        /// </summary>
        /// <example>Trace already closed: a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The trace IDs that are already closed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_ids")]
        public global::System.Collections.Generic.IList<string>? TraceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestOtlpTracesResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Trace already closed: a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6
        /// </param>
        /// <param name="traceIds">
        /// The trace IDs that are already closed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IngestOtlpTracesResponse2(
            string? error,
            global::System.Collections.Generic.IList<string>? traceIds)
        {
            this.Error = error;
            this.TraceIds = traceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestOtlpTracesResponse2" /> class.
        /// </summary>
        public IngestOtlpTracesResponse2()
        {
        }

    }
}