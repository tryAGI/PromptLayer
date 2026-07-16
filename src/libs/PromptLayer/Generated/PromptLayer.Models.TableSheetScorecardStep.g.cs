
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScorecardStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primitive_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScorecardStepPrimitiveTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScorecardStepPrimitiveType PrimitiveType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_column_ids")]
        public global::System.Collections.Generic.IList<string>? SourceColumnIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thresholds")]
        public global::System.Collections.Generic.Dictionary<string, double>? Thresholds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primitive_config")]
        public object? PrimitiveConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_adapter")]
        public object? ScoreAdapter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_column_id")]
        public global::System.Guid? TargetColumnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evidence_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScorecardStepEvidenceModeJsonConverter))]
        public global::PromptLayer.TableSheetScorecardStepEvidenceMode? EvidenceMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_index")]
        public int? OrderIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backing_column_id")]
        public global::System.Guid? BackingColumnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_hash")]
        public string? ConfigHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardStep" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="primitiveType"></param>
        /// <param name="id"></param>
        /// <param name="sourceColumnIds"></param>
        /// <param name="weight"></param>
        /// <param name="required"></param>
        /// <param name="thresholds"></param>
        /// <param name="primitiveConfig"></param>
        /// <param name="scoreAdapter"></param>
        /// <param name="description"></param>
        /// <param name="targetColumnId"></param>
        /// <param name="evidenceMode"></param>
        /// <param name="orderIndex"></param>
        /// <param name="backingColumnId"></param>
        /// <param name="configHash"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardStep(
            string title,
            global::PromptLayer.TableSheetScorecardStepPrimitiveType primitiveType,
            global::System.Guid? id,
            global::System.Collections.Generic.IList<string>? sourceColumnIds,
            double? weight,
            bool? required,
            global::System.Collections.Generic.Dictionary<string, double>? thresholds,
            object? primitiveConfig,
            object? scoreAdapter,
            string? description,
            global::System.Guid? targetColumnId,
            global::PromptLayer.TableSheetScorecardStepEvidenceMode? evidenceMode,
            int? orderIndex,
            global::System.Guid? backingColumnId,
            string? configHash,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.PrimitiveType = primitiveType;
            this.SourceColumnIds = sourceColumnIds;
            this.Weight = weight;
            this.Required = required;
            this.Thresholds = thresholds;
            this.PrimitiveConfig = primitiveConfig;
            this.ScoreAdapter = scoreAdapter;
            this.Description = description;
            this.TargetColumnId = targetColumnId;
            this.EvidenceMode = evidenceMode;
            this.OrderIndex = orderIndex;
            this.BackingColumnId = backingColumnId;
            this.ConfigHash = configHash;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardStep" /> class.
        /// </summary>
        public TableSheetScorecardStep()
        {
        }

    }
}