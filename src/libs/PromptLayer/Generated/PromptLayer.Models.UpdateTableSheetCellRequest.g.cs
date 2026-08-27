
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateTableSheetCellRequest
    {
        /// <summary>
        /// Human-readable display value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_value")]
        public string? DisplayValue { get; set; }

        /// <summary>
        /// Structured value to store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetCellRequest" /> class.
        /// </summary>
        /// <param name="displayValue">
        /// Human-readable display value.
        /// </param>
        /// <param name="value">
        /// Structured value to store.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTableSheetCellRequest(
            string? displayValue,
            object? value)
        {
            this.DisplayValue = displayValue;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetCellRequest" /> class.
        /// </summary>
        public UpdateTableSheetCellRequest()
        {
        }

    }
}