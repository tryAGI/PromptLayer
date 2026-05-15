#nullable enable

namespace PromptLayer
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Edit Evaluation Pipeline Column
        /// </summary>
        /// <param name="reportColumnId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.EditReportColumnResponse> EditReportColumnAsync(
            int reportColumnId,

            global::PromptLayer.EditReportColumnRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Evaluation Pipeline Column
        /// </summary>
        /// <param name="reportColumnId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.EditReportColumnResponse>> EditReportColumnAsResponseAsync(
            int reportColumnId,

            global::PromptLayer.EditReportColumnRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Evaluation Pipeline Column
        /// </summary>
        /// <param name="reportColumnId"></param>
        /// <param name="reportId">
        /// Parent evaluation pipeline ID. Must match the column parent.
        /// </param>
        /// <param name="columnType">
        /// Replacement column type. DATASET columns cannot be edited.
        /// </param>
        /// <param name="configuration">
        /// Replacement column configuration. Schema depends on column_type.
        /// </param>
        /// <param name="name">
        /// New column name. Must be unique within the pipeline.
        /// </param>
        /// <param name="position">
        /// New 1-based position. Cannot overwrite dataset columns.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.EditReportColumnResponse> EditReportColumnAsync(
            int reportColumnId,
            int reportId,
            global::PromptLayer.EditReportColumnRequestColumnType columnType,
            object? configuration = default,
            string? name = default,
            int? position = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}