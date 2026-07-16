
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScorecardCalculation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecard_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScorecardId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SheetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SheetRevision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScorecardCalculationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScorecardCalculationStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_score")]
        public double? AggregateScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScorecardCalculationAggregateVerdictJsonConverter))]
        public global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict? AggregateVerdict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criterion_summaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CriterionSummaries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drift_summary")]
        public object? DriftSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_hash")]
        public string? ConfigHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_summary")]
        public string? ErrorSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardCalculation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="scorecardId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="sheetId"></param>
        /// <param name="sheetRevision"></param>
        /// <param name="status"></param>
        /// <param name="criterionSummaries"></param>
        /// <param name="aggregateScore"></param>
        /// <param name="aggregateVerdict"></param>
        /// <param name="driftSummary"></param>
        /// <param name="configHash"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="errorSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardCalculation(
            global::System.Guid id,
            global::System.Guid scorecardId,
            int workspaceId,
            global::System.Guid sheetId,
            string sheetRevision,
            global::PromptLayer.TableSheetScorecardCalculationStatus status,
            object criterionSummaries,
            double? aggregateScore,
            global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict? aggregateVerdict,
            object? driftSummary,
            string? configHash,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            string? errorSummary)
        {
            this.Id = id;
            this.ScorecardId = scorecardId;
            this.WorkspaceId = workspaceId;
            this.SheetId = sheetId;
            this.SheetRevision = sheetRevision ?? throw new global::System.ArgumentNullException(nameof(sheetRevision));
            this.Status = status;
            this.AggregateScore = aggregateScore;
            this.AggregateVerdict = aggregateVerdict;
            this.CriterionSummaries = criterionSummaries ?? throw new global::System.ArgumentNullException(nameof(criterionSummaries));
            this.DriftSummary = driftSummary;
            this.ConfigHash = configHash;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.ErrorSummary = errorSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardCalculation" /> class.
        /// </summary>
        public TableSheetScorecardCalculation()
        {
        }

    }
}