#nullable enable

namespace PromptLayer
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Edit Evaluation Pipeline Column<br/>
        /// Update an existing column on an evaluation pipeline. Use this to fix a bug in a CODE_EXECUTION script, change a column's configuration, rename it, or reorder it — without recreating the whole pipeline. Cannot edit DATASET columns. Editing a column re-queues the affected cells.
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
        /// Edit Evaluation Pipeline Column<br/>
        /// Update an existing column on an evaluation pipeline. Use this to fix a bug in a CODE_EXECUTION script, change a column's configuration, rename it, or reorder it — without recreating the whole pipeline. Cannot edit DATASET columns. Editing a column re-queues the affected cells.
        /// </summary>
        /// <param name="reportColumnId"></param>
        /// <param name="reportId">
        /// Parent evaluation pipeline ID. Must match the column's report.
        /// </param>
        /// <param name="columnType">
        /// Column type. DATASET is not allowed.
        /// </param>
        /// <param name="configuration">
        /// Replacement column configuration. Schema varies by column_type.
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