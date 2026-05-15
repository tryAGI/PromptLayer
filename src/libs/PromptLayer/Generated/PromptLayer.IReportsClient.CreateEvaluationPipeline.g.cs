#nullable enable

namespace PromptLayer
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Create Evaluation Pipeline
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateEvaluationPipelineResponse> CreateEvaluationPipelineAsync(

            global::PromptLayer.CreateEvaluationPipelineRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Evaluation Pipeline
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateEvaluationPipelineResponse>> CreateEvaluationPipelineAsResponseAsync(

            global::PromptLayer.CreateEvaluationPipelineRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Evaluation Pipeline
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group to use.
        /// </param>
        /// <param name="name">
        /// Name for the pipeline. Auto-generated if omitted.
        /// </param>
        /// <param name="folderId">
        /// Folder ID for organization.
        /// </param>
        /// <param name="datasetVersionNumber">
        /// Specific dataset version. Uses latest published version if omitted.
        /// </param>
        /// <param name="columns">
        /// Evaluation columns to add to the pipeline.
        /// </param>
        /// <param name="scoreConfiguration">
        /// Optional custom scoring logic.
        /// </param>
        /// <param name="externalIds">
        /// External ID mappings to attach to the pipeline.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateEvaluationPipelineResponse> CreateEvaluationPipelineAsync(
            int datasetGroupId,
            string? name = default,
            int? folderId = default,
            int? datasetVersionNumber = default,
            global::System.Collections.Generic.IList<global::PromptLayer.EvaluationColumnDefinition>? columns = default,
            global::PromptLayer.ScoreConfiguration? scoreConfiguration = default,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}