
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetScorecardAggregation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_step_failure_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScorecardAggregationRequiredStepFailureBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior RequiredStepFailureBehavior { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PassThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warn_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WarnThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardAggregation" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="requiredStepFailureBehavior"></param>
        /// <param name="passThreshold"></param>
        /// <param name="warnThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardAggregation(
            string method,
            global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior requiredStepFailureBehavior,
            double passThreshold,
            double warnThreshold)
        {
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.RequiredStepFailureBehavior = requiredStepFailureBehavior;
            this.PassThreshold = passThreshold;
            this.WarnThreshold = warnThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardAggregation" /> class.
        /// </summary>
        public TableSheetScorecardAggregation()
        {
        }

    }
}