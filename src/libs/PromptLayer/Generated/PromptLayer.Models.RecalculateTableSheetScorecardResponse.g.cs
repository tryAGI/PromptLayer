
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecalculateTableSheetScorecardResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("calculation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CalculationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.RecalculateTableSheetScorecardResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.RecalculateTableSheetScorecardResponseStatus Status { get; set; }

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
        /// Initializes a new instance of the <see cref="RecalculateTableSheetScorecardResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="calculationId"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecalculateTableSheetScorecardResponse(
            bool success,
            global::System.Guid calculationId,
            global::PromptLayer.RecalculateTableSheetScorecardResponseStatus status,
            int version)
        {
            this.Success = success;
            this.CalculationId = calculationId;
            this.Status = status;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecalculateTableSheetScorecardResponse" /> class.
        /// </summary>
        public RecalculateTableSheetScorecardResponse()
        {
        }

    }
}