#nullable enable

namespace PromptLayer
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Delete Reports by Name
        /// </summary>
        /// <param name="reportName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DeleteReportsByNameResponse> DeleteReportsByNameAsync(
            string reportName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}