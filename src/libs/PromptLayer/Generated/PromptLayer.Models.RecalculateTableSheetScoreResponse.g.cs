
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecalculateTableSheetScoreResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("score_configuration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScoreConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusJsonConverter))]
        public global::PromptLayer.RecalculateTableSheetScoreResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecalculateTableSheetScoreResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="scoreConfigurationId"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecalculateTableSheetScoreResponse(
            bool success,
            global::System.Guid scoreConfigurationId,
            global::PromptLayer.RecalculateTableSheetScoreResponseStatus? status)
        {
            this.Success = success;
            this.ScoreConfigurationId = scoreConfigurationId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecalculateTableSheetScoreResponse" /> class.
        /// </summary>
        public RecalculateTableSheetScoreResponse()
        {
        }

    }
}