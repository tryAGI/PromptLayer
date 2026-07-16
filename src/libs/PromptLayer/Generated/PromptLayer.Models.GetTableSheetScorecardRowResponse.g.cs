
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTableSheetScorecardRowResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CalculationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecard_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScorecardId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SheetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_score")]
        public double? AggregateScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.GetTableSheetScorecardRowResponseAggregateVerdictJsonConverter))]
        public global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict? AggregateVerdict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object StepResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drift_summary")]
        public object? DriftSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale_state")]
        public object? StaleState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_summary")]
        public object? ErrorSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_hash")]
        public string? ConfigHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_hash")]
        public string? InputHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computed_at")]
        public global::System.DateTime? ComputedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetScorecardRowResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="id"></param>
        /// <param name="calculationId"></param>
        /// <param name="scorecardId"></param>
        /// <param name="sheetId"></param>
        /// <param name="rowIndex"></param>
        /// <param name="stepResults"></param>
        /// <param name="aggregateScore"></param>
        /// <param name="aggregateVerdict"></param>
        /// <param name="driftSummary"></param>
        /// <param name="staleState"></param>
        /// <param name="errorSummary"></param>
        /// <param name="configHash"></param>
        /// <param name="inputHash"></param>
        /// <param name="computedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTableSheetScorecardRowResponse(
            bool success,
            global::System.Guid id,
            global::System.Guid calculationId,
            global::System.Guid scorecardId,
            global::System.Guid sheetId,
            int rowIndex,
            object stepResults,
            double? aggregateScore,
            global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict? aggregateVerdict,
            object? driftSummary,
            object? staleState,
            object? errorSummary,
            string? configHash,
            string? inputHash,
            global::System.DateTime? computedAt)
        {
            this.Success = success;
            this.Id = id;
            this.CalculationId = calculationId;
            this.ScorecardId = scorecardId;
            this.SheetId = sheetId;
            this.RowIndex = rowIndex;
            this.AggregateScore = aggregateScore;
            this.AggregateVerdict = aggregateVerdict;
            this.StepResults = stepResults ?? throw new global::System.ArgumentNullException(nameof(stepResults));
            this.DriftSummary = driftSummary;
            this.StaleState = staleState;
            this.ErrorSummary = errorSummary;
            this.ConfigHash = configHash;
            this.InputHash = inputHash;
            this.ComputedAt = computedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetScorecardRowResponse" /> class.
        /// </summary>
        public GetTableSheetScorecardRowResponse()
        {
        }

    }
}