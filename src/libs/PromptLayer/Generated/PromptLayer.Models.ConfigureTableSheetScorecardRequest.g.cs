
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigureTableSheetScorecardRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluated_column_ids")]
        public global::System.Collections.Generic.IList<string>? EvaluatedColumnIds { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardStep>? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Aggregation { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTableSheetScorecardRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="aggregation"></param>
        /// <param name="evaluatedColumnIds">
        /// Default Value: []
        /// </param>
        /// <param name="steps">
        /// Default Value: []
        /// </param>
        /// <param name="displayConfig"></param>
        /// <param name="baselineConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureTableSheetScorecardRequest(
            string name,
            object aggregation,
            global::System.Collections.Generic.IList<string>? evaluatedColumnIds,
            global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardStep>? steps,
            object? displayConfig,
            object? baselineConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EvaluatedColumnIds = evaluatedColumnIds;
            this.Steps = steps;
            this.Aggregation = aggregation ?? throw new global::System.ArgumentNullException(nameof(aggregation));
            this.DisplayConfig = displayConfig;
            this.BaselineConfig = baselineConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTableSheetScorecardRequest" /> class.
        /// </summary>
        public ConfigureTableSheetScorecardRequest()
        {
        }

    }
}