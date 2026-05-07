#nullable enable

namespace PromptLayer
{
    public partial interface IExternalIdsClient
    {
        /// <summary>
        /// Upsert Prompt Template by External ID<br/>
        /// Publish a prompt template by external ID. Existing mappings create a new version on the mapped prompt template. Missing mappings create or update a prompt template and attach the mapping.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="externalId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreatePromptTemplateResponse> UpsertPromptTemplateByExternalIdAsync(
            string source,
            string externalId,

            global::PromptLayer.CreatePromptTemplate request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Prompt Template by External ID<br/>
        /// Publish a prompt template by external ID. Existing mappings create a new version on the mapped prompt template. Missing mappings create or update a prompt template and attach the mapping.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="externalId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreatePromptTemplateResponse>> UpsertPromptTemplateByExternalIdAsResponseAsync(
            string source,
            string externalId,

            global::PromptLayer.CreatePromptTemplate request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Prompt Template by External ID<br/>
        /// Publish a prompt template by external ID. Existing mappings create a new version on the mapped prompt template. Missing mappings create or update a prompt template and attach the mapping.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="externalId"></param>
        /// <param name="promptTemplate">
        /// Template metadata, including prompt name, tags, folder, and workspace fields.
        /// </param>
        /// <param name="promptVersion">
        /// Version content and configuration.
        /// </param>
        /// <param name="releaseLabels">
        /// Release labels to create or move to the newly created version.
        /// </param>
        /// <param name="externalIds">
        /// Identifiers from other systems.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreatePromptTemplateResponse> UpsertPromptTemplateByExternalIdAsync(
            string source,
            string externalId,
            global::PromptLayer.BasePromptTemplate promptTemplate,
            global::PromptLayer.PromptVersion promptVersion,
            global::System.Collections.Generic.IList<string>? releaseLabels = default,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}