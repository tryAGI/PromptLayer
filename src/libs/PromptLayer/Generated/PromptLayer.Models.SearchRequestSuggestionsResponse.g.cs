
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestSuggestionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Suggested values for the requested field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestSuggestionsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="values">
        /// Suggested values for the requested field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestSuggestionsResponse(
            bool success,
            global::System.Collections.Generic.IList<string> values)
        {
            this.Success = success;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestSuggestionsResponse" /> class.
        /// </summary>
        public SearchRequestSuggestionsResponse()
        {
        }

    }
}