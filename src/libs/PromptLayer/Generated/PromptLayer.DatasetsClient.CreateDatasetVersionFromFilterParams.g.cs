
#nullable enable

namespace PromptLayer
{
    public partial class DatasetsClient
    {


        private static readonly global::PromptLayer.EndPointSecurityRequirement s_CreateDatasetVersionFromFilterParamsSecurityRequirement0 =
            new global::PromptLayer.EndPointSecurityRequirement
            {
                Authorizations = new global::PromptLayer.EndPointAuthorizationRequirement[]
                {                    new global::PromptLayer.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-API-KEY",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::PromptLayer.EndPointSecurityRequirement[] s_CreateDatasetVersionFromFilterParamsSecurityRequirements =
            new global::PromptLayer.EndPointSecurityRequirement[]
            {                s_CreateDatasetVersionFromFilterParamsSecurityRequirement0,
            };
        partial void PrepareCreateDatasetVersionFromFilterParamsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest request);
        partial void PrepareCreateDatasetVersionFromFilterParamsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest request);
        partial void ProcessCreateDatasetVersionFromFilterParamsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDatasetVersionFromFilterParamsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Dataset Version from Filter Params
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(

            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDatasetVersionFromFilterParamsArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::PromptLayer.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateDatasetVersionFromFilterParamsSecurityRequirements,
                operationName: "CreateDatasetVersionFromFilterParamsAsync");

            var __pathBuilder = new global::PromptLayer.PathBuilder(
                path: "/api/public/v2/dataset-versions/from-filter-params",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateDatasetVersionFromFilterParamsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateDatasetVersionFromFilterParamsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Access denied to this dataset group
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::PromptLayer.ErrorResponse? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::PromptLayer.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::PromptLayer.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::PromptLayer.ApiException<global::PromptLayer.ErrorResponse>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Dataset group not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::PromptLayer.ErrorResponse? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::PromptLayer.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::PromptLayer.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::PromptLayer.ApiException<global::PromptLayer.ErrorResponse>(
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateDatasetVersionFromFilterParamsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
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
        /// <summary>
        /// Create Dataset Version from Filter Params
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group where the new version will be created
        /// </param>
        /// <param name="variablesToParse">
        /// List of variables to parse from the request logs
        /// </param>
        /// <param name="promptId">
        /// Filter by specific prompt ID
        /// </param>
        /// <param name="promptVersionId">
        /// Filter by specific prompt version ID
        /// </param>
        /// <param name="promptLabelId">
        /// Filter by specific prompt label ID
        /// </param>
        /// <param name="workspaceId">
        /// Filter by specific workspace ID
        /// </param>
        /// <param name="startTime">
        /// Filter logs after this timestamp (ISO format)
        /// </param>
        /// <param name="endTime">
        /// Filter logs before this timestamp (ISO format)
        /// </param>
        /// <param name="tags">
        /// Filter by specific tags
        /// </param>
        /// <param name="metadata">
        /// Filter by metadata key-value pairs
        /// </param>
        /// <param name="scores">
        /// Filter by score ranges
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(
            int datasetGroupId,
            global::System.Collections.Generic.IList<string>? variablesToParse = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            int? workspaceId = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.Dictionary<string, global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScores2>? scores = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest
            {
                DatasetGroupId = datasetGroupId,
                VariablesToParse = variablesToParse,
                PromptId = promptId,
                PromptVersionId = promptVersionId,
                PromptLabelId = promptLabelId,
                WorkspaceId = workspaceId,
                StartTime = startTime,
                EndTime = endTime,
                Tags = tags,
                Metadata = metadata,
                Scores = scores,
            };

            return await CreateDatasetVersionFromFilterParamsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}