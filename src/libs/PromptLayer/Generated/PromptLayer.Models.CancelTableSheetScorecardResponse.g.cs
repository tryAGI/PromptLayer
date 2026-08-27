
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelTableSheetScorecardResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.CancelTableSheetScorecardResponseScorecard Scorecard { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CancelledCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExecutionIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculation_id")]
        public global::System.Guid? CalculationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTableSheetScorecardResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="scorecard"></param>
        /// <param name="cancelledCount"></param>
        /// <param name="executionIds"></param>
        /// <param name="calculationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelTableSheetScorecardResponse(
            bool success,
            string message,
            global::PromptLayer.CancelTableSheetScorecardResponseScorecard scorecard,
            int cancelledCount,
            global::System.Collections.Generic.IList<string> executionIds,
            global::System.Guid? calculationId)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Scorecard = scorecard ?? throw new global::System.ArgumentNullException(nameof(scorecard));
            this.CancelledCount = cancelledCount;
            this.ExecutionIds = executionIds ?? throw new global::System.ArgumentNullException(nameof(executionIds));
            this.CalculationId = calculationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTableSheetScorecardResponse" /> class.
        /// </summary>
        public CancelTableSheetScorecardResponse()
        {
        }

    }
}