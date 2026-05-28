#nullable enable

namespace PromptLayer
{
    public partial interface ISkillCollectionsClient
    {
        /// <summary>
        /// List Skill Collections
        /// </summary>
        /// <param name="createdByEmail"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="updatedBefore"></param>
        /// <param name="externalSource"></param>
        /// <param name="externalId"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListSkillCollectionsResponse> ListSkillCollectionsPublicAsync(
            string? createdByEmail = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            string? externalSource = default,
            string? externalId = default,
            global::PromptLayer.ListSkillCollectionsPublicSortBy? sortBy = default,
            global::PromptLayer.ListSkillCollectionsPublicSortOrder? sortOrder = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Skill Collections
        /// </summary>
        /// <param name="createdByEmail"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="updatedBefore"></param>
        /// <param name="externalSource"></param>
        /// <param name="externalId"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListSkillCollectionsResponse>> ListSkillCollectionsPublicAsResponseAsync(
            string? createdByEmail = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            string? externalSource = default,
            string? externalId = default,
            global::PromptLayer.ListSkillCollectionsPublicSortBy? sortBy = default,
            global::PromptLayer.ListSkillCollectionsPublicSortOrder? sortOrder = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}