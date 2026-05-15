
#nullable enable

namespace PromptLayer
{
    public partial class FoldersClient
    {


        private static readonly global::PromptLayer.EndPointSecurityRequirement s_ListFolderEntitiesApiPublicV2FoldersEntitiesGetSecurityRequirement0 =
            new global::PromptLayer.EndPointSecurityRequirement
            {
                Authorizations = new global::PromptLayer.EndPointAuthorizationRequirement[]
                {                    new global::PromptLayer.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "X-API-KEY",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::PromptLayer.EndPointSecurityRequirement[] s_ListFolderEntitiesApiPublicV2FoldersEntitiesGetSecurityRequirements =
            new global::PromptLayer.EndPointSecurityRequirement[]
            {                s_ListFolderEntitiesApiPublicV2FoldersEntitiesGetSecurityRequirement0,
            };
        partial void PrepareListFolderEntitiesApiPublicV2FoldersEntitiesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int workspaceId,
            ref int? folderId,
            ref global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>? filterType,
            ref string? searchQuery,
            ref bool? flatten,
            ref bool? includeMetadata,
            ref string? createdByEmail,
            ref global::System.DateTime? createdAfter,
            ref global::System.DateTime? createdBefore,
            ref global::System.DateTime? updatedAfter,
            ref global::System.DateTime? updatedBefore,
            ref string? externalSource,
            ref string? externalId,
            ref global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy? sortBy,
            ref global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder? sortOrder,
            ref global::PromptLayer.OneOf<string, global::System.Collections.Generic.IList<string>>? tags,
            ref bool? semanticSearch,
            ref int? semanticSearchTopK,
            ref double? semanticSearchThreshold);
        partial void PrepareListFolderEntitiesApiPublicV2FoldersEntitiesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int workspaceId,
            int? folderId,
            global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>? filterType,
            string? searchQuery,
            bool? flatten,
            bool? includeMetadata,
            string? createdByEmail,
            global::System.DateTime? createdAfter,
            global::System.DateTime? createdBefore,
            global::System.DateTime? updatedAfter,
            global::System.DateTime? updatedBefore,
            string? externalSource,
            string? externalId,
            global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy? sortBy,
            global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder? sortOrder,
            global::PromptLayer.OneOf<string, global::System.Collections.Generic.IList<string>>? tags,
            bool? semanticSearch,
            int? semanticSearchTopK,
            double? semanticSearchThreshold);
        partial void ProcessListFolderEntitiesApiPublicV2FoldersEntitiesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFolderEntitiesApiPublicV2FoldersEntitiesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Folder Entities
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace to list entities from.
        /// </param>
        /// <param name="folderId">
        /// The ID of the folder to list entities from. If not provided, lists entities at the workspace root level.
        /// </param>
        /// <param name="filterType">
        /// Filter entities by type. Can be a single type or a list of types. If not provided, all entity types are returned.
        /// </param>
        /// <param name="searchQuery">
        /// Search entities by name (case-insensitive partial match).
        /// </param>
        /// <param name="flatten">
        /// When true, returns all entities recursively within the folder hierarchy instead of only direct children.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeMetadata">
        /// When true, includes type-specific metadata for each entity (e.g., prompt type, latest version number).<br/>
        /// Default Value: false
        /// </param>
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
        /// <param name="tags"></param>
        /// <param name="semanticSearch">
        /// Default Value: false
        /// </param>
        /// <param name="semanticSearchTopK">
        /// Default Value: 100
        /// </param>
        /// <param name="semanticSearchThreshold"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::PromptLayer.ListFolderEntitiesResponse> ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync(
            int workspaceId,
            int? folderId = default,
            global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>? filterType = default,
            string? searchQuery = default,
            bool? flatten = default,
            bool? includeMetadata = default,
            string? createdByEmail = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            string? externalSource = default,
            string? externalId = default,
            global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy? sortBy = default,
            global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder? sortOrder = default,
            global::PromptLayer.OneOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            bool? semanticSearch = default,
            int? semanticSearchTopK = default,
            double? semanticSearchThreshold = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsResponseAsync(
                workspaceId: workspaceId,
                folderId: folderId,
                filterType: filterType,
                searchQuery: searchQuery,
                flatten: flatten,
                includeMetadata: includeMetadata,
                createdByEmail: createdByEmail,
                createdAfter: createdAfter,
                createdBefore: createdBefore,
                updatedAfter: updatedAfter,
                updatedBefore: updatedBefore,
                externalSource: externalSource,
                externalId: externalId,
                sortBy: sortBy,
                sortOrder: sortOrder,
                tags: tags,
                semanticSearch: semanticSearch,
                semanticSearchTopK: semanticSearchTopK,
                semanticSearchThreshold: semanticSearchThreshold,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Folder Entities
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace to list entities from.
        /// </param>
        /// <param name="folderId">
        /// The ID of the folder to list entities from. If not provided, lists entities at the workspace root level.
        /// </param>
        /// <param name="filterType">
        /// Filter entities by type. Can be a single type or a list of types. If not provided, all entity types are returned.
        /// </param>
        /// <param name="searchQuery">
        /// Search entities by name (case-insensitive partial match).
        /// </param>
        /// <param name="flatten">
        /// When true, returns all entities recursively within the folder hierarchy instead of only direct children.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeMetadata">
        /// When true, includes type-specific metadata for each entity (e.g., prompt type, latest version number).<br/>
        /// Default Value: false
        /// </param>
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
        /// <param name="tags"></param>
        /// <param name="semanticSearch">
        /// Default Value: false
        /// </param>
        /// <param name="semanticSearchTopK">
        /// Default Value: 100
        /// </param>
        /// <param name="semanticSearchThreshold"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListFolderEntitiesResponse>> ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsResponseAsync(
            int workspaceId,
            int? folderId = default,
            global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>? filterType = default,
            string? searchQuery = default,
            bool? flatten = default,
            bool? includeMetadata = default,
            string? createdByEmail = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            string? externalSource = default,
            string? externalId = default,
            global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy? sortBy = default,
            global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder? sortOrder = default,
            global::PromptLayer.OneOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            bool? semanticSearch = default,
            int? semanticSearchTopK = default,
            double? semanticSearchThreshold = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListFolderEntitiesApiPublicV2FoldersEntitiesGetArguments(
                httpClient: HttpClient,
                workspaceId: ref workspaceId,
                folderId: ref folderId,
                filterType: ref filterType,
                searchQuery: ref searchQuery,
                flatten: ref flatten,
                includeMetadata: ref includeMetadata,
                createdByEmail: ref createdByEmail,
                createdAfter: ref createdAfter,
                createdBefore: ref createdBefore,
                updatedAfter: ref updatedAfter,
                updatedBefore: ref updatedBefore,
                externalSource: ref externalSource,
                externalId: ref externalId,
                sortBy: ref sortBy,
                sortOrder: ref sortOrder,
                tags: ref tags,
                semanticSearch: ref semanticSearch,
                semanticSearchTopK: ref semanticSearchTopK,
                semanticSearchThreshold: ref semanticSearchThreshold);


            var __authorizations = global::PromptLayer.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListFolderEntitiesApiPublicV2FoldersEntitiesGetSecurityRequirements,
                operationName: "ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync");

            using var __timeoutCancellationTokenSource = global::PromptLayer.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::PromptLayer.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::PromptLayer.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::PromptLayer.PathBuilder(
                                path: "/api/public/v2/folders/entities",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("workspace_id", workspaceId.ToString()!)
                                .AddOptionalParameter("folder_id", folderId?.ToString())
                                .AddOptionalParameter("filter_type", filterType?.ToString())
                                .AddOptionalParameter("search_query", searchQuery)
                                .AddOptionalParameter("flatten", flatten?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("include_metadata", includeMetadata?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("created_by_email", createdByEmail)
                                .AddOptionalParameter("created_after", createdAfter?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("created_before", createdBefore?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updated_after", updatedAfter?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updated_before", updatedBefore?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("external_source", externalSource)
                                .AddOptionalParameter("external_id", externalId)
                                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                                .AddOptionalParameter("sort_order", sortOrder?.ToValueString())
                                .AddOptionalParameter("tags", tags?.ToString())
                                .AddOptionalParameter("semantic_search", semanticSearch?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("semantic_search_top_k", semanticSearchTopK?.ToString())
                                .AddOptionalParameter("semantic_search_threshold", semanticSearchThreshold?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::PromptLayer.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                global::PromptLayer.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListFolderEntitiesApiPublicV2FoldersEntitiesGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    workspaceId: workspaceId!,
                    folderId: folderId,
                    filterType: filterType,
                    searchQuery: searchQuery,
                    flatten: flatten,
                    includeMetadata: includeMetadata,
                    createdByEmail: createdByEmail,
                    createdAfter: createdAfter,
                    createdBefore: createdBefore,
                    updatedAfter: updatedAfter,
                    updatedBefore: updatedBefore,
                    externalSource: externalSource,
                    externalId: externalId,
                    sortBy: sortBy,
                    sortOrder: sortOrder,
                    tags: tags,
                    semanticSearch: semanticSearch,
                    semanticSearchTopK: semanticSearchTopK,
                    semanticSearchThreshold: semanticSearchThreshold);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::PromptLayer.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::PromptLayer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListFolderEntitiesApiPublicV2FoldersEntitiesGet",
                                methodName: "ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync",
                                pathTemplate: "\"/api/public/v2/folders/entities\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::PromptLayer.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::PromptLayer.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::PromptLayer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListFolderEntitiesApiPublicV2FoldersEntitiesGet",
                                methodName: "ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync",
                                pathTemplate: "\"/api/public/v2/folders/entities\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::PromptLayer.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::PromptLayer.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::PromptLayer.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::PromptLayer.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::PromptLayer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListFolderEntitiesApiPublicV2FoldersEntitiesGet",
                                methodName: "ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync",
                                pathTemplate: "\"/api/public/v2/folders/entities\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::PromptLayer.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListFolderEntitiesApiPublicV2FoldersEntitiesGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::PromptLayer.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::PromptLayer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListFolderEntitiesApiPublicV2FoldersEntitiesGet",
                                methodName: "ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync",
                                pathTemplate: "\"/api/public/v2/folders/entities\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::PromptLayer.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::PromptLayer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListFolderEntitiesApiPublicV2FoldersEntitiesGet",
                                methodName: "ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync",
                                pathTemplate: "\"/api/public/v2/folders/entities\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad request - Missing or invalid workspace_id
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::PromptLayer.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::PromptLayer.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::PromptLayer.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::PromptLayer.ApiException<global::PromptLayer.ErrorResponse>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Unauthorized - missing or invalid API key.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::PromptLayer.ErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::PromptLayer.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::PromptLayer.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::PromptLayer.ApiException<global::PromptLayer.ErrorResponse>(
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_401,
                                    ResponseObject = __value_401,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Folder not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::PromptLayer.FolderNotFoundError? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::PromptLayer.FolderNotFoundError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::PromptLayer.FolderNotFoundError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }

                                throw new global::PromptLayer.ApiException<global::PromptLayer.FolderNotFoundError>(
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_404,
                                    ResponseObject = __value_404,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Validation error - request parameters or body are invalid.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::PromptLayer.ApiException<global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>?>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListFolderEntitiesApiPublicV2FoldersEntitiesGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::PromptLayer.ListFolderEntitiesResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListFolderEntitiesResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::PromptLayer.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::PromptLayer.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::PromptLayer.ListFolderEntitiesResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListFolderEntitiesResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::PromptLayer.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::PromptLayer.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}