#nullable enable

namespace PromptLayer
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset Version from File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFileResponse> CreateDatasetVersionFromFileAsync(

            global::PromptLayer.CreateDatasetVersionFromFileRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Version from File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateDatasetVersionFromFileResponse>> CreateDatasetVersionFromFileAsResponseAsync(

            global::PromptLayer.CreateDatasetVersionFromFileRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Version from File
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group where the new version will be created.
        /// </param>
        /// <param name="fileName">
        /// Name of the CSV or JSON file. Must end with .csv or .json.
        /// </param>
        /// <param name="fileContentBase64">
        /// Base64-encoded file content. Maximum decoded file size is 100MB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFileResponse> CreateDatasetVersionFromFileAsync(
            int datasetGroupId,
            string fileName,
            string fileContentBase64,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}