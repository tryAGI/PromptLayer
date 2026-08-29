
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Optional request log to create alongside the span. If request times are omitted, they are inherited from the span start/end times.
    /// </summary>
    public sealed partial class SpanLogRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}