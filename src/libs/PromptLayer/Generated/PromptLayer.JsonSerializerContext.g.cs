
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::PromptLayer.JsonConverters.EvaluationRunStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationRunStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EdgeConditionalOperatorJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EdgeConditionalOperatorNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetPromptTemplateProvider2JsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetPromptTemplateProvider2NullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CompletionPromptContentItemDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CompletionPromptContentItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CompletionPromptTemplateFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CompletionPromptTemplateFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CompletionPromptTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CompletionPromptTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TextContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TextContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ThinkingContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ThinkingContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.MediaFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.MediaFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ImageContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ImageContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.MediaContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.MediaContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.MediaVariableTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.MediaVariableTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.OutputMediaContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.OutputMediaContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.OutputMediaContentMediaTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.OutputMediaContentMediaTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CodeContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CodeContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ServerToolUseContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ServerToolUseContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.WebSearchResultTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.WebSearchResultTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CodeExecutionResultContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CodeExecutionResultContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.McpListToolsContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.McpListToolsContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.McpCallContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.McpCallContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.McpApprovalRequestContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.McpApprovalRequestContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.McpApprovalResponseContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.McpApprovalResponseContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.BashCodeExecutionToolResultContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.BashCodeExecutionToolResultContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ShellCallContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ShellCallContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ShellCallOutputContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ShellCallOutputContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ApplyPatchCallContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ApplyPatchCallContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ApplyPatchCallOutputContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ApplyPatchCallOutputContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.BuiltInToolTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.BuiltInToolTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SystemMessageTemplateFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SystemMessageTemplateFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SystemMessageContentItemDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SystemMessageContentItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.UserMessageTemplateFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.UserMessageTemplateFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.UserMessageContentItemDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.UserMessageContentItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AssistantMessageTemplateFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AssistantMessageTemplateFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.FunctionMessageTemplateFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.FunctionMessageTemplateFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.DeveloperMessageTemplateFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.DeveloperMessageTemplateFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ChatPromptMessageDiscriminatorRoleJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ChatPromptMessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ChatPromptTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ChatPromptTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptVersionPromptTemplateDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptVersionPromptTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ToolMessageTemplateFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ToolMessageTemplateFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ToolMessageContentItemDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ToolMessageContentItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ToolDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PlaceholderMessageTemplateFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PlaceholderMessageTemplateFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PlaceholderMessageRoleJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PlaceholderMessageRoleNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestInputDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestOutputDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestErrorType2JsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestErrorType2NullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestResponseStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.LogRequestResponseStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SpanKindJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SpanKindNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StatusCodeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StatusCodeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EntityTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EntityTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptEntityMetadataTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptEntityMetadataTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SearchRequestLogsRequestSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SearchRequestLogsRequestSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SearchRequestLogsRequestSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.SearchRequestLogsRequestSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterFieldJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterFieldNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterOperatorJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterOperatorNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterGroupLogicJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterGroupLogicNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2JsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2NullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportResponseStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportResponseStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetDatasetRowsResponseRowItemTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetDatasetRowsResponseRowItemTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetEvaluationRowsResponseRowItemStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ContentItemJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ContentItem2JsonConverter),

            typeof(global::PromptLayer.JsonConverters.ContentItem3JsonConverter),

            typeof(global::PromptLayer.JsonConverters.ContentVariant1ItemJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ContentVariant1Item2JsonConverter),

            typeof(global::PromptLayer.JsonConverters.ContentItem4JsonConverter),

            typeof(global::PromptLayer.JsonConverters.MessagesItemJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptTemplateJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptTemplate2JsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptTemplate3JsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptTemplate4JsonConverter),

            typeof(global::PromptLayer.JsonConverters.ContentItem5JsonConverter),

            typeof(global::PromptLayer.JsonConverters.ToolJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ContentVariant1Item3JsonConverter),

            typeof(global::PromptLayer.JsonConverters.InputJsonConverter),

            typeof(global::PromptLayer.JsonConverters.OutputJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptTemplate5JsonConverter),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.NodeUpdate, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.MessageFunctionCall, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.ChatToolChoice, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<string, double?, bool?, byte[], object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.FolderExistsError, string>),

            typeof(global::PromptLayer.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Evaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.EvaluationRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationRunStatus), TypeInfoPropertyName = "EvaluationRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationRunStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetSnippetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetSnippetUsageResponseLabelUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetSnippetUsageResponseLabelUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WorkflowNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EdgeConditional))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EdgeConditionalOperator), TypeInfoPropertyName = "EdgeConditionalOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Edge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.EdgeConditional>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.WorkflowNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.NodeUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PatchWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.NodeUpdate, object>), TypeInfoPropertyName = "OneOfNodeUpdateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CreateWorkflowResponseNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateWorkflowResponseNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Base))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateProvider2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem), TypeInfoPropertyName = "ContentItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ThinkingContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OutputMediaContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ServerToolUseContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchToolResultContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeExecutionResultContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpListToolsContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpCallContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalRequestContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalResponseContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BashCodeExecutionToolResultContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallOutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallOutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptContentItemDiscriminatorType), TypeInfoPropertyName = "CompletionPromptContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptTemplateFormat), TypeInfoPropertyName = "CompletionPromptTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptType), TypeInfoPropertyName = "CompletionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FileAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MapAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContainerFileAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextContentType), TypeInfoPropertyName = "TextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>), TypeInfoPropertyName = "OneOfWebAnnotationFileAnnotationMapAnnotationContainerFileAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ThinkingContentType), TypeInfoPropertyName = "ThinkingContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Media))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaFormat), TypeInfoPropertyName = "MediaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ImageContentType), TypeInfoPropertyName = "ImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaContentType), TypeInfoPropertyName = "MediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaVariableType), TypeInfoPropertyName = "MediaVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OutputMediaContentType), TypeInfoPropertyName = "OutputMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OutputMediaContentMediaType), TypeInfoPropertyName = "OutputMediaContentMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeContentType), TypeInfoPropertyName = "CodeContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ServerToolUseContentType), TypeInfoPropertyName = "ServerToolUseContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchResultType), TypeInfoPropertyName = "WebSearchResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchToolResultContentType), TypeInfoPropertyName = "WebSearchToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.WebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeExecutionResultContentType), TypeInfoPropertyName = "CodeExecutionResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpListToolsContentType), TypeInfoPropertyName = "McpListToolsContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, object, object>), TypeInfoPropertyName = "AnyOfStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpCallContentType), TypeInfoPropertyName = "McpCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalRequestContentType), TypeInfoPropertyName = "McpApprovalRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalResponseContentType), TypeInfoPropertyName = "McpApprovalResponseContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BashCodeExecutionToolResultContentType), TypeInfoPropertyName = "BashCodeExecutionToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContentType), TypeInfoPropertyName = "TextEditorCodeExecutionToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallContentType), TypeInfoPropertyName = "ShellCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallOutputContentType), TypeInfoPropertyName = "ShellCallOutputContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallContentType), TypeInfoPropertyName = "ApplyPatchCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallOutputContentType), TypeInfoPropertyName = "ApplyPatchCallOutputContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BuiltInTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BuiltInToolType), TypeInfoPropertyName = "BuiltInToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessageTemplateFormat), TypeInfoPropertyName = "SystemMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem2), TypeInfoPropertyName = "ContentItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessageContentItemDiscriminatorType), TypeInfoPropertyName = "SystemMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessageTemplateFormat), TypeInfoPropertyName = "UserMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem3), TypeInfoPropertyName = "ContentItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessageContentItemDiscriminatorType), TypeInfoPropertyName = "UserMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessageTemplateFormat), TypeInfoPropertyName = "AssistantMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item), TypeInfoPropertyName = "ContentVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType), TypeInfoPropertyName = "AssistantMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessageTemplateFormat), TypeInfoPropertyName = "FunctionMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item2), TypeInfoPropertyName = "ContentVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType), TypeInfoPropertyName = "FunctionMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessageTemplateFormat), TypeInfoPropertyName = "DeveloperMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem4), TypeInfoPropertyName = "ContentItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminatorType), TypeInfoPropertyName = "DeveloperMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MessagesItem), TypeInfoPropertyName = "MessagesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPromptMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPromptMessageDiscriminatorRole), TypeInfoPropertyName = "ChatPromptMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::PromptLayer.MessageFunctionCall, object>), TypeInfoPropertyName = "AnyOfStringMessageFunctionCallObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::PromptLayer.ChatToolChoice, object>), TypeInfoPropertyName = "AnyOfStringChatToolChoiceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPromptType), TypeInfoPropertyName = "ChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate), TypeInfoPropertyName = "PromptTemplate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType), TypeInfoPropertyName = "GetPromptTemplateResponsePromptTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SnippetReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateRawResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate2), TypeInfoPropertyName = "PromptTemplate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateRawResponsePromptTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateRawResponsePromptTemplateDiscriminatorType), TypeInfoPropertyName = "GetPromptTemplateRawResponsePromptTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.SnippetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateLabelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BasePromptTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate3), TypeInfoPropertyName = "PromptTemplate32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptVersionPromptTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptVersionPromptTemplateDiscriminatorType), TypeInfoPropertyName = "PromptVersionPromptTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PatchPromptTemplateVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>), TypeInfoPropertyName = "AnyOfObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreatePromptTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreatePromptTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate4), TypeInfoPropertyName = "PromptTemplate42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreatePromptTemplateResponsePromptTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreatePromptTemplateResponsePromptTemplateDiscriminatorType), TypeInfoPropertyName = "CreatePromptTemplateResponsePromptTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessageTemplateFormat), TypeInfoPropertyName = "ToolMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem5), TypeInfoPropertyName = "ContentItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessageContentItemDiscriminatorType), TypeInfoPropertyName = "ToolMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolDiscriminatorType), TypeInfoPropertyName = "ToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListPromptTemplates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetPromptTemplateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageTemplateFormat), TypeInfoPropertyName = "PlaceholderMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item3), TypeInfoPropertyName = "ContentVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType), TypeInfoPropertyName = "PlaceholderMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageRole), TypeInfoPropertyName = "PlaceholderMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Input), TypeInfoPropertyName = "Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestInputDiscriminatorType), TypeInfoPropertyName = "LogRequestInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Output), TypeInfoPropertyName = "Output2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestOutputDiscriminatorType), TypeInfoPropertyName = "LogRequestOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestStatus), TypeInfoPropertyName = "LogRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestErrorType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestResponseStatus), TypeInfoPropertyName = "LogRequestResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptBlueprint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate5), TypeInfoPropertyName = "PromptTemplate52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptBlueprintPromptTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptBlueprintPromptTemplateDiscriminatorType), TypeInfoPropertyName = "PromptBlueprintPromptTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanKind), TypeInfoPropertyName = "SpanKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StatusCode), TypeInfoPropertyName = "StatusCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Span))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSpansBulk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSpansBulkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DatasetGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateFolderSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Folder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FolderExistsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ParentFolderNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FolderNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EntityType), TypeInfoPropertyName = "EntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FolderEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>), TypeInfoPropertyName = "OneOfPromptEntityMetadataWorkflowEntityMetadataDatasetEntityMetadataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptEntityMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WorkflowEntityMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DatasetEntityMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptEntityMetadataType), TypeInfoPropertyName = "PromptEntityMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.FolderEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EntityReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MoveFolderEntitiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteFolderEntitiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FolderEntitiesCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ResolveFolderIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpExportTraceServiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OtlpKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpKeyValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpanScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpSpanStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpanEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpSpanEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpanLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpSpanLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpKeyValueValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpKeyValueValueArrayValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpExportTraceServiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OtlpExportTraceServiceResponsePartialSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestLogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestLogsRequestSortBy), TypeInfoPropertyName = "SearchRequestLogsRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestLogsRequestSortOrder), TypeInfoPropertyName = "SearchRequestLogsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterField), TypeInfoPropertyName = "StructuredFilterField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterOperator), TypeInfoPropertyName = "StructuredFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, double?, bool?, byte[], object>), TypeInfoPropertyName = "OneOfStringDoubleBooleanByteArrayObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroupLogic), TypeInfoPropertyName = "StructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>), TypeInfoPropertyName = "OneOfStructuredFilterStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreatePromptLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CreateEvaluationPipelineRequestColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineRequestColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineRequestScoreConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage), TypeInfoPropertyName = "CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnRequestColumnType), TypeInfoPropertyName = "AddReportColumnRequestColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunReportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RenameReportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EditReportColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EditReportColumnRequestColumnType), TypeInfoPropertyName = "EditReportColumnRequestColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScores2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScores2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDraftDatasetVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddRequestLogToDatasetVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SaveDraftDatasetVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsStatus), TypeInfoPropertyName = "ListDatasetsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListEvaluationsStatus), TypeInfoPropertyName = "ListEvaluationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetAllPromptTemplatesGetStatus), TypeInfoPropertyName = "GetAllPromptTemplatesGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_a2e389e01f671d8d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.IngestOtlpTracesContentType), TypeInfoPropertyName = "IngestOtlpTracesContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.IngestOtlpTracesContentEncoding), TypeInfoPropertyName = "IngestOtlpTracesContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetRequestSearchSuggestionsField), TypeInfoPropertyName = "GetRequestSearchSuggestionsField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreatePromptLabelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteReportsByNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CreateEvaluationPipelineResponseReportColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineResponseReportColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunReportResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunReportResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunReportResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunReportResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportResponseReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportResponseStatus), TypeInfoPropertyName = "GetReportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportResponseStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportResponseStatsStatusCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreScoreType), TypeInfoPropertyName = "GetReportScoreResponseScoreScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>), TypeInfoPropertyName = "GetReportScoreResponseScoreDetailsVariant4_e167c334488aa373")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RenameReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EditReportColumnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetRequestResponsePromptBlueprint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetTraceResponseSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTraceResponseSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetDatasetRowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.GetDatasetRowsResponseRowItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetDatasetRowsResponseRowItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetDatasetRowsResponseRowItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetDatasetRowsResponseRowItemType), TypeInfoPropertyName = "GetDatasetRowsResponseRowItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetEvaluationRowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.GetEvaluationRowsResponseRowItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetEvaluationRowsResponseRowItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetEvaluationRowsResponseRowItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetEvaluationRowsResponseRowItemType), TypeInfoPropertyName = "GetEvaluationRowsResponseRowItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetEvaluationRowsResponseRowItemStatus), TypeInfoPropertyName = "GetEvaluationRowsResponseRowItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListEvaluationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Evaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDraftDatasetVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDraftDatasetVersionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddRequestLogToDatasetVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SaveDraftDatasetVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>), TypeInfoPropertyName = "AnyOfBadRequestErrorValidationError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>), TypeInfoPropertyName = "OneOfDictionaryStringGetWorkflowVersionExecutionResultsResponseVariant12Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>), TypeInfoPropertyName = "OneOfDictionaryStringGetWorkflowVersionExecutionResultsResponseVariant14Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListWorkflowsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListWorkflowsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListWorkflowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListWorkflowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowResponseNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetWorkflowResponseNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowResponseEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetWorkflowResponseEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetWorkflowLabelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<global::PromptLayer.FolderExistsError, string>), TypeInfoPropertyName = "AnyOfFolderExistsErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetRequestSearchSuggestionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.EvaluationRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetSnippetUsageResponseLabelUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.EdgeConditional>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.WorkflowNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CreateWorkflowResponseNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.WebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.SnippetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<object, global::System.Collections.Generic.List<object>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetPromptTemplateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.FolderEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OtlpKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OtlpSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OtlpSpanEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OtlpSpanLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CreateEvaluationPipelineRequestColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_13c51ceff6c2844e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CreateEvaluationPipelineResponseReportColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetTraceResponseSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.GetDatasetRowsResponseRowItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetDatasetRowsResponseRowItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.GetEvaluationRowsResponseRowItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetEvaluationRowsResponseRowItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Evaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListWorkflowsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}