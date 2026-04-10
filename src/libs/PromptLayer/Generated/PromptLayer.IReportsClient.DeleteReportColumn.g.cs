#nullable enable

namespace PromptLayer
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Delete Evaluation Pipeline Column<br/>
        /// Delete a single column from an evaluation pipeline. Surrounding columns shift left to fill the gap. Cannot delete DATASET columns. Cells in columns to the right of the deleted column are re-queued.
        /// </summary>
        /// <param name="reportColumnId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteReportColumnAsync(
            int reportColumnId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}