
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTableSheetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// New display position within the table (0-based).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetRequest" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="index">
        /// New display position within the table (0-based).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTableSheetRequest(
            string? title,
            int? index)
        {
            this.Title = title;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetRequest" /> class.
        /// </summary>
        public UpdateTableSheetRequest()
        {
        }

    }
}