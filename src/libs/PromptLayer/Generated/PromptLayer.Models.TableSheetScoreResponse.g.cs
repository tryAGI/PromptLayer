
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetScoreResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SheetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeJsonConverter))]
        public global::PromptLayer.TableSheetScoreResponseScoringType? ScoringType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScoreColumn> Columns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_score")]
        public double? AggregateScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scored_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScoredRows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExcludedRows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculated_at")]
        public global::System.DateTime? CalculatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_matrix")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>>>? ScoreMatrix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_matrix_metrics")]
        public global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScoreMetric>? ScoreMatrixMetrics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusJsonConverter))]
        public global::PromptLayer.TableSheetScoreResponseStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_calculation_error")]
        public string? ScoreCalculationError { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_custom_scoring")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCustomScoring { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_configuration")]
        public global::PromptLayer.TableSheetScoreConfiguration? ScoreConfiguration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScoreResponseScoreType ScoreType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_score")]
        public double? OverallScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Details { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Aggregate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object PerColumn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="sheetId"></param>
        /// <param name="columns"></param>
        /// <param name="totalRows"></param>
        /// <param name="scoredRows"></param>
        /// <param name="excludedRows"></param>
        /// <param name="hasCustomScoring"></param>
        /// <param name="scoreType"></param>
        /// <param name="details"></param>
        /// <param name="aggregate"></param>
        /// <param name="perColumn"></param>
        /// <param name="scoringType"></param>
        /// <param name="aggregateScore"></param>
        /// <param name="calculatedAt"></param>
        /// <param name="scoreMatrix"></param>
        /// <param name="scoreMatrixMetrics"></param>
        /// <param name="status"></param>
        /// <param name="scoreCalculationError"></param>
        /// <param name="scoreConfiguration"></param>
        /// <param name="overallScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScoreResponse(
            bool success,
            global::System.Guid sheetId,
            global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScoreColumn> columns,
            int totalRows,
            int scoredRows,
            int excludedRows,
            bool hasCustomScoring,
            global::PromptLayer.TableSheetScoreResponseScoreType scoreType,
            object details,
            object aggregate,
            object perColumn,
            global::PromptLayer.TableSheetScoreResponseScoringType? scoringType,
            double? aggregateScore,
            global::System.DateTime? calculatedAt,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>>>? scoreMatrix,
            global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScoreMetric>? scoreMatrixMetrics,
            global::PromptLayer.TableSheetScoreResponseStatus? status,
            string? scoreCalculationError,
            global::PromptLayer.TableSheetScoreConfiguration? scoreConfiguration,
            double? overallScore)
        {
            this.Success = success;
            this.SheetId = sheetId;
            this.ScoringType = scoringType;
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
            this.AggregateScore = aggregateScore;
            this.TotalRows = totalRows;
            this.ScoredRows = scoredRows;
            this.ExcludedRows = excludedRows;
            this.CalculatedAt = calculatedAt;
            this.ScoreMatrix = scoreMatrix;
            this.ScoreMatrixMetrics = scoreMatrixMetrics;
            this.Status = status;
            this.ScoreCalculationError = scoreCalculationError;
            this.HasCustomScoring = hasCustomScoring;
            this.ScoreConfiguration = scoreConfiguration;
            this.ScoreType = scoreType;
            this.OverallScore = overallScore;
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.Aggregate = aggregate ?? throw new global::System.ArgumentNullException(nameof(aggregate));
            this.PerColumn = perColumn ?? throw new global::System.ArgumentNullException(nameof(perColumn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreResponse" /> class.
        /// </summary>
        public TableSheetScoreResponse()
        {
        }

    }
}