
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTableSheetRequestSourceRequestLogsSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeJsonConverter))]
        public global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType Type { get; set; }

        /// <summary>
        /// Specific request log IDs to import. When omitted, filter params are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_log_ids")]
        public global::System.Collections.Generic.IList<int>? RequestLogIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public int? PromptId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        public int? PromptVersionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_label_id")]
        public int? PromptLabelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetRequestSourceRequestLogsSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="requestLogIds">
        /// Specific request log IDs to import. When omitted, filter params are used.
        /// </param>
        /// <param name="promptId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetRequestSourceRequestLogsSource(
            global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType type,
            global::System.Collections.Generic.IList<int>? requestLogIds,
            int? promptId,
            int? promptVersionId,
            int? promptLabelId,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime)
        {
            this.Type = type;
            this.RequestLogIds = requestLogIds;
            this.PromptId = promptId;
            this.PromptVersionId = promptVersionId;
            this.PromptLabelId = promptLabelId;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetRequestSourceRequestLogsSource" /> class.
        /// </summary>
        public CreateTableSheetRequestSourceRequestLogsSource()
        {
        }

    }
}