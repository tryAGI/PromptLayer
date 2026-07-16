
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScorecardGetResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecard")]
        public global::PromptLayer.TableSheetScorecard? Scorecard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_calculation")]
        public global::PromptLayer.TableSheetScorecardCalculation? LatestCalculation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_calculation")]
        public global::PromptLayer.TableSheetScorecardCalculation? DisplayCalculation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criterion_summaries")]
        public object? CriterionSummaries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drift_summary")]
        public object? DriftSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::PromptLayer.TableSheetScorecardGetResponseProgress? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardGetResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="scorecard"></param>
        /// <param name="latestCalculation"></param>
        /// <param name="displayCalculation"></param>
        /// <param name="criterionSummaries"></param>
        /// <param name="driftSummary"></param>
        /// <param name="progress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardGetResponse(
            bool success,
            global::PromptLayer.TableSheetScorecard? scorecard,
            global::PromptLayer.TableSheetScorecardCalculation? latestCalculation,
            global::PromptLayer.TableSheetScorecardCalculation? displayCalculation,
            object? criterionSummaries,
            object? driftSummary,
            global::PromptLayer.TableSheetScorecardGetResponseProgress? progress)
        {
            this.Success = success;
            this.Scorecard = scorecard;
            this.LatestCalculation = latestCalculation;
            this.DisplayCalculation = displayCalculation;
            this.CriterionSummaries = criterionSummaries;
            this.DriftSummary = driftSummary;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardGetResponse" /> class.
        /// </summary>
        public TableSheetScorecardGetResponse()
        {
        }

    }
}