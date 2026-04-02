
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class PromptLayerClient : global::PromptLayer.IPromptLayerClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.promptlayer.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::PromptLayer.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::PromptLayer.JsonConverters.EvaluationRunStatusJsonConverter(),
                    new global::PromptLayer.JsonConverters.EvaluationRunStatusNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.EdgeConditionalOperatorJsonConverter(),
                    new global::PromptLayer.JsonConverters.EdgeConditionalOperatorNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetPromptTemplateProvider2JsonConverter(),
                    new global::PromptLayer.JsonConverters.GetPromptTemplateProvider2NullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.CompletionPromptContentItemDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.CompletionPromptContentItemDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.CompletionPromptTemplateFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.CompletionPromptTemplateFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.CompletionPromptTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.CompletionPromptTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.TextContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.TextContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ThinkingContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ThinkingContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.MediaFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.MediaFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ImageContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ImageContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.MediaContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.MediaContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.MediaVariableTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.MediaVariableTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.OutputMediaContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.OutputMediaContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.OutputMediaContentMediaTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.OutputMediaContentMediaTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.CodeContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.CodeContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ServerToolUseContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ServerToolUseContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.WebSearchResultTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.WebSearchResultTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.CodeExecutionResultContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.CodeExecutionResultContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.McpListToolsContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.McpListToolsContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.McpCallContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.McpCallContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.McpApprovalRequestContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.McpApprovalRequestContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.McpApprovalResponseContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.McpApprovalResponseContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.BashCodeExecutionToolResultContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.BashCodeExecutionToolResultContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ShellCallContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ShellCallContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ShellCallOutputContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ShellCallOutputContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ApplyPatchCallContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ApplyPatchCallContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ApplyPatchCallOutputContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ApplyPatchCallOutputContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.BuiltInToolTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.BuiltInToolTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.SystemMessageTemplateFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.SystemMessageTemplateFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.SystemMessageContentItemDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.SystemMessageContentItemDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.UserMessageTemplateFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.UserMessageTemplateFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.UserMessageContentItemDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.UserMessageContentItemDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.AssistantMessageTemplateFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.AssistantMessageTemplateFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.FunctionMessageTemplateFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.FunctionMessageTemplateFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.DeveloperMessageTemplateFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.DeveloperMessageTemplateFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ChatPromptMessageDiscriminatorRoleJsonConverter(),
                    new global::PromptLayer.JsonConverters.ChatPromptMessageDiscriminatorRoleNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ChatPromptTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ChatPromptTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptVersionPromptTemplateDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptVersionPromptTemplateDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ToolMessageTemplateFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.ToolMessageTemplateFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ToolMessageContentItemDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ToolMessageContentItemDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ToolDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.PlaceholderMessageTemplateFormatJsonConverter(),
                    new global::PromptLayer.JsonConverters.PlaceholderMessageTemplateFormatNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.PlaceholderMessageRoleJsonConverter(),
                    new global::PromptLayer.JsonConverters.PlaceholderMessageRoleNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestInputDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestInputDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestOutputDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestOutputDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestStatusJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestStatusNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestErrorType2JsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestErrorType2NullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestResponseStatusJsonConverter(),
                    new global::PromptLayer.JsonConverters.LogRequestResponseStatusNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.SpanKindJsonConverter(),
                    new global::PromptLayer.JsonConverters.SpanKindNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.StatusCodeJsonConverter(),
                    new global::PromptLayer.JsonConverters.StatusCodeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.EntityTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.EntityTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptEntityMetadataTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptEntityMetadataTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.SearchRequestLogsRequestSortByJsonConverter(),
                    new global::PromptLayer.JsonConverters.SearchRequestLogsRequestSortByNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.SearchRequestLogsRequestSortOrderJsonConverter(),
                    new global::PromptLayer.JsonConverters.SearchRequestLogsRequestSortOrderNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.StructuredFilterFieldJsonConverter(),
                    new global::PromptLayer.JsonConverters.StructuredFilterFieldNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.StructuredFilterOperatorJsonConverter(),
                    new global::PromptLayer.JsonConverters.StructuredFilterOperatorNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.StructuredFilterGroupLogicJsonConverter(),
                    new global::PromptLayer.JsonConverters.StructuredFilterGroupLogicNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguageJsonConverter(),
                    new global::PromptLayer.JsonConverters.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguageNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ListDatasetsStatusJsonConverter(),
                    new global::PromptLayer.JsonConverters.ListDatasetsStatusNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ListEvaluationsStatusJsonConverter(),
                    new global::PromptLayer.JsonConverters.ListEvaluationsStatusNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2JsonConverter(),
                    new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2NullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemJsonConverter(),
                    new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingJsonConverter(),
                    new global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetReportResponseStatusJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetReportResponseStatusNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetDatasetRowsResponseRowItemTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetDatasetRowsResponseRowItemTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemTypeJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemTypeNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemStatusJsonConverter(),
                    new global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemStatusNullableJsonConverter(),
                    new global::PromptLayer.JsonConverters.ContentItemJsonConverter(),
                    new global::PromptLayer.JsonConverters.ContentItem2JsonConverter(),
                    new global::PromptLayer.JsonConverters.ContentItem3JsonConverter(),
                    new global::PromptLayer.JsonConverters.ContentVariant1ItemJsonConverter(),
                    new global::PromptLayer.JsonConverters.ContentVariant1Item2JsonConverter(),
                    new global::PromptLayer.JsonConverters.ContentItem4JsonConverter(),
                    new global::PromptLayer.JsonConverters.MessagesItemJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptTemplateJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptTemplate2JsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptTemplate3JsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptTemplate4JsonConverter(),
                    new global::PromptLayer.JsonConverters.ContentItem5JsonConverter(),
                    new global::PromptLayer.JsonConverters.ToolJsonConverter(),
                    new global::PromptLayer.JsonConverters.ContentVariant1Item3JsonConverter(),
                    new global::PromptLayer.JsonConverters.InputJsonConverter(),
                    new global::PromptLayer.JsonConverters.OutputJsonConverter(),
                    new global::PromptLayer.JsonConverters.PromptTemplate5JsonConverter(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.NodeUpdate, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.MessageFunctionCall, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.ChatToolChoice, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<string, double?, bool?, byte[], object>(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>(),
                    new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>(),
                    new global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.FolderExistsError, string>(),
                    new global::PromptLayer.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluationsClient Evaluations => new EvaluationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FoldersClient Folders => new FoldersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GroupClient Group => new GroupClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata => new MetadataClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OtlpClient Otlp => new OtlpClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt => new PromptClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplatesClient PromptTemplates => new PromptTemplatesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReportsClient Reports => new ReportsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RequestClient Request => new RequestClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RestClient Rest => new RestClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScoreClient Score => new ScoreClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpansClient Spans => new SpansClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TrackingClient Tracking => new TrackingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkflowClient Workflow => new WorkflowClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the PromptLayerClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public PromptLayerClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::PromptLayer.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::PromptLayer.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}