
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigureTableSheetScoreResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_configuration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScoreConfigurationId { get; set; }

        /// <summary>
        /// Returned as null by this endpoint. Use the recalculation endpoint to queue score calculation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Always true after updating the score configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_recalculation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresRecalculation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTableSheetScoreResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="scoreConfigurationId"></param>
        /// <param name="requiresRecalculation">
        /// Always true after updating the score configuration.
        /// </param>
        /// <param name="version"></param>
        /// <param name="status">
        /// Returned as null by this endpoint. Use the recalculation endpoint to queue score calculation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureTableSheetScoreResponse(
            bool success,
            string message,
            global::System.Guid scoreConfigurationId,
            bool requiresRecalculation,
            int version,
            string? status)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ScoreConfigurationId = scoreConfigurationId;
            this.Status = status;
            this.RequiresRecalculation = requiresRecalculation;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTableSheetScoreResponse" /> class.
        /// </summary>
        public ConfigureTableSheetScoreResponse()
        {
        }

    }
}