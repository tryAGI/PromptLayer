
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationRowsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PerPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Rows containing dataset cells followed by evaluation result cells.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>> Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRowsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="columns"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="pages"></param>
        /// <param name="total"></param>
        /// <param name="rows">
        /// Rows containing dataset cells followed by evaluation result cells.
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRowsResponse(
            bool success,
            global::System.Collections.Generic.IList<string> columns,
            int page,
            int perPage,
            int pages,
            int total,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>> rows,
            string? message)
        {
            this.Success = success;
            this.Message = message;
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
            this.Page = page;
            this.PerPage = perPage;
            this.Pages = pages;
            this.Total = total;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRowsResponse" /> class.
        /// </summary>
        public EvaluationRowsResponse()
        {
        }

    }
}