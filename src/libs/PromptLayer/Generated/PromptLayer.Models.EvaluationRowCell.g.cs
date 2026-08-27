
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationRowCell
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.EvaluationRowCellTypeJsonConverter))]
        public global::PromptLayer.EvaluationRowCellType Type { get; set; }

        /// <summary>
        /// Evaluation cell status, such as PASSED, FAILED, RUNNING, or SKIPPED.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Evaluation result value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Error details for failed cells.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRowCell" /> class.
        /// </summary>
        /// <param name="status">
        /// Evaluation cell status, such as PASSED, FAILED, RUNNING, or SKIPPED.
        /// </param>
        /// <param name="type"></param>
        /// <param name="value">
        /// Evaluation result value.
        /// </param>
        /// <param name="errorMessage">
        /// Error details for failed cells.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRowCell(
            string status,
            global::PromptLayer.EvaluationRowCellType type,
            object? value,
            string? errorMessage)
        {
            this.Type = type;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Value = value;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRowCell" /> class.
        /// </summary>
        public EvaluationRowCell()
        {
        }

    }
}