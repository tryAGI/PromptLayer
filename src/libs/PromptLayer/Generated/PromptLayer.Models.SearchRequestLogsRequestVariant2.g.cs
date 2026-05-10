
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestLogsRequestVariant2
    {
        /// <summary>
        /// Page number for pagination. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Number of results per page. Defaults to 10, maximum 25.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_page")]
        public int? PerPage { get; set; }

        /// <summary>
        /// When true, includes the prompt template name in each result item. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_prompt_name")]
        public bool? IncludePromptName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestLogsRequestVariant2" /> class.
        /// </summary>
        /// <param name="page">
        /// Page number for pagination. Defaults to 1.
        /// </param>
        /// <param name="perPage">
        /// Number of results per page. Defaults to 10, maximum 25.
        /// </param>
        /// <param name="includePromptName">
        /// When true, includes the prompt template name in each result item. Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestLogsRequestVariant2(
            int? page,
            int? perPage,
            bool? includePromptName)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.IncludePromptName = includePromptName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestLogsRequestVariant2" /> class.
        /// </summary>
        public SearchRequestLogsRequestVariant2()
        {
        }

    }
}