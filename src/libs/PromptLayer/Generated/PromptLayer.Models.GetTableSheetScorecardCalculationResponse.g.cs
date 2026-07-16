
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTableSheetScorecardCalculationResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("calculation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScorecardCalculation Calculation { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetScorecardCalculationResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="calculation"></param>
        /// <param name="criterionSummaries"></param>
        /// <param name="driftSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTableSheetScorecardCalculationResponse(
            bool success,
            global::PromptLayer.TableSheetScorecardCalculation calculation,
            object? criterionSummaries,
            object? driftSummary)
        {
            this.Success = success;
            this.Calculation = calculation ?? throw new global::System.ArgumentNullException(nameof(calculation));
            this.CriterionSummaries = criterionSummaries;
            this.DriftSummary = driftSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetScorecardCalculationResponse" /> class.
        /// </summary>
        public GetTableSheetScorecardCalculationResponse()
        {
        }

    }
}