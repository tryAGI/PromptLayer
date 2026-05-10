
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEvaluationRowsResponseRowItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.GetEvaluationRowsResponseRowItemType Type { get; set; }

        /// <summary>
        /// The cell value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Evaluation status (only for eval cells)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemStatusJsonConverter))]
        public global::PromptLayer.GetEvaluationRowsResponseRowItemStatus? Status { get; set; }

        /// <summary>
        /// Error details (only present for failed eval cells)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvaluationRowsResponseRowItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value">
        /// The cell value
        /// </param>
        /// <param name="status">
        /// Evaluation status (only for eval cells)
        /// </param>
        /// <param name="errorMessage">
        /// Error details (only present for failed eval cells)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEvaluationRowsResponseRowItem(
            global::PromptLayer.GetEvaluationRowsResponseRowItemType type,
            object? value,
            global::PromptLayer.GetEvaluationRowsResponseRowItemStatus? status,
            string? errorMessage)
        {
            this.Type = type;
            this.Value = value;
            this.Status = status;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvaluationRowsResponseRowItem" /> class.
        /// </summary>
        public GetEvaluationRowsResponseRowItem()
        {
        }

    }
}