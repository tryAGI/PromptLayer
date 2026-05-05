
#nullable enable

namespace PromptLayer
{
    public partial class PromptTemplatesClient
    {


        private static readonly global::PromptLayer.EndPointSecurityRequirement s_GetPromptTemplateRawSecurityRequirement0 =
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
        private static readonly global::PromptLayer.EndPointSecurityRequirement[] s_GetPromptTemplateRawSecurityRequirements =
            new global::PromptLayer.EndPointSecurityRequirement[]
            {                s_GetPromptTemplateRawSecurityRequirement0,
            };
        partial void PrepareGetPromptTemplateRawArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identifier,
            ref int? version,
            ref string? label,
            ref bool? resolveSnippets,
            ref bool? includeLlmKwargs);
        partial void PrepareGetPromptTemplateRawRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identifier,
            int? version,
            string? label,
            bool? resolveSnippets,
            bool? includeLlmKwargs);
        partial void ProcessGetPromptTemplateRawResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPromptTemplateRawResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Prompt Template Raw Data<br/>
        /// Retrieve raw prompt template data without applying input variables. Designed for GitHub sync, local caching, and template inspection. By default, snippets are resolved (expanded). Use resolve_snippets=false to get the raw template with snippet references intact.
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="version">
        /// Specific version number to retrieve. Mutually exclusive with `label`.
        /// </param>
        /// <param name="label">
        /// Release label name to retrieve (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="resolveSnippets">
        /// When true (default), snippets are expanded in the returned prompt_template. When false, raw @@@snippet@@@ references are preserved.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeLlmKwargs">
        /// When true, includes provider-specific llm_kwargs in the response. Requires model metadata to be set on the template.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::PromptLayer.GetPromptTemplateRawResponse> GetPromptTemplateRawAsync(
            string identifier,
            int? version = default,
            string? label = default,
            bool? resolveSnippets = default,
            bool? includeLlmKwargs = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetPromptTemplateRawAsResponseAsync(
                identifier: identifier,
                version: version,
                label: label,
                resolveSnippets: resolveSnippets,
                includeLlmKwargs: includeLlmKwargs,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Prompt Template Raw Data<br/>
        /// Retrieve raw prompt template data without applying input variables. Designed for GitHub sync, local caching, and template inspection. By default, snippets are resolved (expanded). Use resolve_snippets=false to get the raw template with snippet references intact.
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="version">
        /// Specific version number to retrieve. Mutually exclusive with `label`.
        /// </param>
        /// <param name="label">
        /// Release label name to retrieve (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="resolveSnippets">
        /// When true (default), snippets are expanded in the returned prompt_template. When false, raw @@@snippet@@@ references are preserved.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeLlmKwargs">
        /// When true, includes provider-specific llm_kwargs in the response. Requires model metadata to be set on the template.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.GetPromptTemplateRawResponse>> GetPromptTemplateRawAsResponseAsync(
            string identifier,
            int? version = default,
            string? label = default,
            bool? resolveSnippets = default,
            bool? includeLlmKwargs = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetPromptTemplateRawArguments(
                httpClient: HttpClient,
                identifier: ref identifier,
                version: ref version,
                label: ref label,
                resolveSnippets: ref resolveSnippets,
                includeLlmKwargs: ref includeLlmKwargs);


            var __authorizations = global::PromptLayer.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetPromptTemplateRawSecurityRequirements,
                operationName: "GetPromptTemplateRawAsync");

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
                                path: $"/prompt-templates/{identifier}",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("version", version?.ToString())
                                .AddOptionalParameter("label", label)
                                .AddOptionalParameter("resolve_snippets", resolveSnippets?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("include_llm_kwargs", includeLlmKwargs?.ToString().ToLowerInvariant())
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
                PrepareGetPromptTemplateRawRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    identifier: identifier!,
                    version: version,
                    label: label,
                    resolveSnippets: resolveSnippets,
                    includeLlmKwargs: includeLlmKwargs);

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
                                operationId: "GetPromptTemplateRaw",
                                methodName: "GetPromptTemplateRawAsync",
                                pathTemplate: "$\"/prompt-templates/{identifier}\"",
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
                                operationId: "GetPromptTemplateRaw",
                                methodName: "GetPromptTemplateRawAsync",
                                pathTemplate: "$\"/prompt-templates/{identifier}\"",
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
                                operationId: "GetPromptTemplateRaw",
                                methodName: "GetPromptTemplateRawAsync",
                                pathTemplate: "$\"/prompt-templates/{identifier}\"",
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
                ProcessGetPromptTemplateRawResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::PromptLayer.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::PromptLayer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetPromptTemplateRaw",
                                methodName: "GetPromptTemplateRawAsync",
                                pathTemplate: "$\"/prompt-templates/{identifier}\"",
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
                                operationId: "GetPromptTemplateRaw",
                                methodName: "GetPromptTemplateRawAsync",
                                pathTemplate: "$\"/prompt-templates/{identifier}\"",
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
                            // Prompt template not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::PromptLayer.ErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::PromptLayer.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::PromptLayer.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::PromptLayer.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::PromptLayer.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::PromptLayer.ApiException<global::PromptLayer.HTTPValidationError>(
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
                                ProcessGetPromptTemplateRawResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::PromptLayer.GetPromptTemplateRawResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.GetPromptTemplateRawResponse>(
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

                                    var __value = await global::PromptLayer.GetPromptTemplateRawResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.GetPromptTemplateRawResponse>(
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