
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListTableSheetVersionsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Items returned on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.TableSheetVersion> Data { get; set; }

        /// <summary>
        /// Cursor pagination metadata for public table list endpoints. Cursors are opaque and include the active sort, order, cursor value, and a hash of the active filter set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.PublicListPagination Pagination { get; set; }

        /// <summary>
        /// Filters applied to this page. The cursor includes a hash of this filter set, so changing filters while reusing a cursor returns an invalid cursor error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.EmptyPublicFilters Filters { get; set; }

        /// <summary>
        /// Number of items returned on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetVersionsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="data">
        /// Items returned on this page.
        /// </param>
        /// <param name="pagination">
        /// Cursor pagination metadata for public table list endpoints. Cursors are opaque and include the active sort, order, cursor value, and a hash of the active filter set.
        /// </param>
        /// <param name="filters">
        /// Filters applied to this page. The cursor includes a hash of this filter set, so changing filters while reusing a cursor returns an invalid cursor error.
        /// </param>
        /// <param name="count">
        /// Number of items returned on this page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTableSheetVersionsResponse(
            bool success,
            global::System.Collections.Generic.IList<global::PromptLayer.TableSheetVersion> data,
            global::PromptLayer.PublicListPagination pagination,
            global::PromptLayer.EmptyPublicFilters filters,
            int count)
        {
            this.Success = success;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetVersionsResponse" /> class.
        /// </summary>
        public ListTableSheetVersionsResponse()
        {
        }

    }
}