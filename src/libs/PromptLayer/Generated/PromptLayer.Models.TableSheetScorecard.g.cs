
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetScorecard
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
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_table_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SmartTableId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SheetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluated_column_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EvaluatedColumnIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScorecardAggregation Aggregation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_config")]
        public object? DisplayConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_config")]
        public object? BaselineConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScorecardStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScorecardStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale_state")]
        public global::PromptLayer.TableSheetScorecardStaleState? StaleState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_calculation_id")]
        public global::System.Guid? LatestCalculationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_hash")]
        public string? ConfigHash { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardStep> Steps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecard" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workspaceId"></param>
        /// <param name="smartTableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="name"></param>
        /// <param name="evaluatedColumnIds"></param>
        /// <param name="aggregation"></param>
        /// <param name="status"></param>
        /// <param name="steps"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="displayConfig"></param>
        /// <param name="baselineConfig"></param>
        /// <param name="staleState"></param>
        /// <param name="latestCalculationId"></param>
        /// <param name="configHash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecard(
            global::System.Guid id,
            int workspaceId,
            global::System.Guid smartTableId,
            global::System.Guid sheetId,
            string name,
            global::System.Collections.Generic.IList<string> evaluatedColumnIds,
            global::PromptLayer.TableSheetScorecardAggregation aggregation,
            global::PromptLayer.TableSheetScorecardStatus status,
            global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardStep> steps,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? displayConfig,
            object? baselineConfig,
            global::PromptLayer.TableSheetScorecardStaleState? staleState,
            global::System.Guid? latestCalculationId,
            string? configHash)
        {
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.SmartTableId = smartTableId;
            this.SheetId = sheetId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EvaluatedColumnIds = evaluatedColumnIds ?? throw new global::System.ArgumentNullException(nameof(evaluatedColumnIds));
            this.Aggregation = aggregation ?? throw new global::System.ArgumentNullException(nameof(aggregation));
            this.DisplayConfig = displayConfig;
            this.BaselineConfig = baselineConfig;
            this.Status = status;
            this.StaleState = staleState;
            this.LatestCalculationId = latestCalculationId;
            this.ConfigHash = configHash;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecard" /> class.
        /// </summary>
        public TableSheetScorecard()
        {
        }

    }
}