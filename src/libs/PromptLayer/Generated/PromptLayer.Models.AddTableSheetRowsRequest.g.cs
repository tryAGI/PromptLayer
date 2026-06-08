
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTableSheetRowsRequest
    {
        /// <summary>
        /// Number of rows to append (1–100).<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Per-row initial values for text columns. Each element is a map of column_id → value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<object>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTableSheetRowsRequest" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of rows to append (1–100).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="values">
        /// Per-row initial values for text columns. Each element is a map of column_id → value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTableSheetRowsRequest(
            int? count,
            global::System.Collections.Generic.IList<object>? values)
        {
            this.Count = count;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTableSheetRowsRequest" /> class.
        /// </summary>
        public AddTableSheetRowsRequest()
        {
        }

    }
}