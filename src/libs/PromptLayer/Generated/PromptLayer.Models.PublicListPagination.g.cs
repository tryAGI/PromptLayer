
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Cursor pagination metadata for public table list endpoints. Cursors are opaque and include the active sort, order, cursor value, and a hash of the active filter set.
    /// </summary>
    public sealed partial class PublicListPagination
    {
        /// <summary>
        /// Opaque cursor to pass as cursor for the next page, or null when there is no next page. The cursor is valid only with the same sort, order, and filter parameters used to produce it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Reserved for previous-page cursors. Public table list endpoints currently return null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_cursor")]
        public string? PrevCursor { get; set; }

        /// <summary>
        /// Whether another page is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Requested page size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicListPagination" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Whether another page is available.
        /// </param>
        /// <param name="limit">
        /// Requested page size.
        /// </param>
        /// <param name="nextCursor">
        /// Opaque cursor to pass as cursor for the next page, or null when there is no next page. The cursor is valid only with the same sort, order, and filter parameters used to produce it.
        /// </param>
        /// <param name="prevCursor">
        /// Reserved for previous-page cursors. Public table list endpoints currently return null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicListPagination(
            bool hasMore,
            int limit,
            string? nextCursor,
            string? prevCursor)
        {
            this.NextCursor = nextCursor;
            this.PrevCursor = prevCursor;
            this.HasMore = hasMore;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicListPagination" /> class.
        /// </summary>
        public PublicListPagination()
        {
        }

    }
}