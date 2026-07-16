
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTableSheetScorecardRowsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("calculation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CalculationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardRowSummary> Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public int? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetScorecardRowsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="calculationId"></param>
        /// <param name="rows"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTableSheetScorecardRowsResponse(
            bool success,
            global::System.Guid calculationId,
            global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardRowSummary> rows,
            int? nextCursor)
        {
            this.Success = success;
            this.CalculationId = calculationId;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetScorecardRowsResponse" /> class.
        /// </summary>
        public ListTableSheetScorecardRowsResponse()
        {
        }

    }
}