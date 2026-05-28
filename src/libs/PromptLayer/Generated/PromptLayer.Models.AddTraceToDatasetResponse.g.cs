
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTraceToDatasetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// ID of the draft dataset the trace row was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_dataset_id")]
        public int? DraftDatasetId { get; set; }

        /// <summary>
        /// Indicates whether the row was created from a full trace root (`trace`) or a specific span subtree (`span`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeJsonConverter))]
        public global::PromptLayer.AddTraceToDatasetResponseMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTraceToDatasetResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="draftDatasetId">
        /// ID of the draft dataset the trace row was added to.
        /// </param>
        /// <param name="mode">
        /// Indicates whether the row was created from a full trace root (`trace`) or a specific span subtree (`span`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTraceToDatasetResponse(
            bool? success,
            int? draftDatasetId,
            global::PromptLayer.AddTraceToDatasetResponseMode? mode)
        {
            this.Success = success;
            this.DraftDatasetId = draftDatasetId;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTraceToDatasetResponse" /> class.
        /// </summary>
        public AddTraceToDatasetResponse()
        {
        }

    }
}