
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackMetadataRequest
    {
        /// <summary>
        /// PromptLayer request ID to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.AnyOf<int?, string> RequestId { get; set; }

        /// <summary>
        /// Metadata dictionary to associate with the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMetadataRequest" /> class.
        /// </summary>
        /// <param name="requestId">
        /// PromptLayer request ID to update.
        /// </param>
        /// <param name="metadata">
        /// Metadata dictionary to associate with the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackMetadataRequest(
            global::PromptLayer.AnyOf<int?, string> requestId,
            object metadata)
        {
            this.RequestId = requestId;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMetadataRequest" /> class.
        /// </summary>
        public TrackMetadataRequest()
        {
        }

    }
}