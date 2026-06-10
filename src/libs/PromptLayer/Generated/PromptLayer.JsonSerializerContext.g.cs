
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

            typeof(global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EntityTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EntityTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptEntityMetadataTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptEntityMetadataTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterFieldJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterFieldNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterOperatorJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterOperatorNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterGroupLogicJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterGroupLogicNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListPromptTemplateItemPromptTemplateDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListPromptTemplateItemPromptTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ReportColumnSummaryColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ReportColumnSummaryColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.DatasetRowCellTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.DatasetRowCellTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationRowCellTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationRowCellTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CellStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CellStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableImportOperationSourceJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableImportOperationSourceNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableImportOperationStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableImportOperationStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestStatuseJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestStatuseNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetOperationOperationJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetOperationOperationNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableCellStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableCellStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetColumnRequestTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetColumnRequestTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListWorkflowsSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListWorkflowsSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListWorkflowsSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListWorkflowsSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2JsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2NullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetSkillCollectionPublicFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetSkillCollectionPublicFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListToolRegistriesSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListToolRegistriesSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListToolRegistriesSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListToolRegistriesSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTablesOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTablesOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetsOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetsOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetRowsOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetRowsOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetVersionsSortJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetVersionsSortNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetVersionsOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetVersionsOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryRangeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryRangeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryResolutionJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryResolutionNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportResponseStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportResponseStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolResponseResultStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolResponseResultStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CloseTraceResponseClosureStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CloseTraceResponseClosureStatusNullableJsonConverter),

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

            typeof(global::PromptLayer.JsonConverters.SearchRequestLogsRequestJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptTemplate6JsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationResponseJsonConverter),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.NodeUpdate, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.SkillCollectionVersion, object>),

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

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.DatasetGroup, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.Dataset, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<double?, string, global::PromptLayer.TableSheetScoreCellObject>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.FolderExistsError, string>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_a2e389e01f671d8d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>), TypeInfoPropertyName = "GetReportScoreResponseScoreDetailsVariant4_e167c334488aa373")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>?), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_47a8c666c2b64908")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>?), TypeInfoPropertyName = "GetReportScoreResponseScoreDetailsVariant4_819979ee8daaec57")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_13c51ceff6c2844e")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalId))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SkillCollectionErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SkillCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SkillCollectionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.InitialFileUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FileUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FileMove))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSkillCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.InitialFileUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSkillCollectionMultipartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateSkillCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SaveSkillCollectionVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.FileUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.FileMove>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SaveSkillCollectionVersionMultipartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListSkillCollectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.SkillCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetSkillCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.SkillCollectionVersion, object>), TypeInfoPropertyName = "OneOfSkillCollectionVersionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSkillCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateSkillCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SaveSkillCollectionVersionResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListPromptTemplateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListPromptTemplateItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSpansBulkResponseRejectionReason), TypeInfoPropertyName = "CreateSpansBulkResponseRejectionReason2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestLogQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestLogQuerySortBy), TypeInfoPropertyName = "RequestLogQuerySortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestLogQuerySortOrder), TypeInfoPropertyName = "RequestLogQuerySortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsLatencyByDay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsDimensionLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsStatOutputShapeCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsBreakdownEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsToolLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsResponseChartInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMostUsedPromptTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsResponseMostUsedPromptTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::PromptLayer.RequestAnalyticsDimensionLatency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseErrorType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsResponseErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsBreakdownEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMetadataKeysTopItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsResponseMetadataKeysTopItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseOutputKeysTopItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsResponseOutputKeysTopItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsToolLatency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseToolsUsageBar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsResponseToolsUsageBar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMetadataValueBreakdownItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsResponseMetadataValueBreakdownItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestLogsRequest), TypeInfoPropertyName = "SearchRequestLogsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestLogsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterField), TypeInfoPropertyName = "StructuredFilterField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterOperator), TypeInfoPropertyName = "StructuredFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, double?, bool?, byte[], object>), TypeInfoPropertyName = "OneOfStringDoubleBooleanByteArrayObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroupLogic), TypeInfoPropertyName = "StructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>), TypeInfoPropertyName = "OneOfStructuredFilterStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.RequestLogSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestLogSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AttachExternalIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalIdAttachResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalIdsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalIdDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalIdErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate6), TypeInfoPropertyName = "PromptTemplate62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminatorType), TypeInfoPropertyName = "ListPromptTemplateItemPromptTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RateLimitError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationColumnDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationColumnDefinitionColumnType), TypeInfoPropertyName = "EvaluationColumnDefinitionColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ScoreConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ScoreConfigurationCodeLanguage), TypeInfoPropertyName = "ScoreConfigurationCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationPipelineSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ReportColumnSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ReportColumnSummaryColumnType), TypeInfoPropertyName = "ReportColumnSummaryColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.EvaluationColumnDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ReportColumnSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateReportScoreCardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage), TypeInfoPropertyName = "UpdateReportScoreCardRequestCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateReportScoreCardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EditReportColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EditReportColumnRequestColumnType), TypeInfoPropertyName = "EditReportColumnRequestColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EditReportColumnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RenameReportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RenameReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<global::PromptLayer.DatasetGroup, object>), TypeInfoPropertyName = "AnyOfDatasetGroupObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<global::PromptLayer.Dataset, object>), TypeInfoPropertyName = "AnyOfDatasetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy), TypeInfoPropertyName = "CreateDatasetVersionFromFilterParamsRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder), TypeInfoPropertyName = "CreateDatasetVersionFromFilterParamsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DatasetRowCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DatasetRowCellType), TypeInfoPropertyName = "DatasetRowCellType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationRowCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationRowCellType), TypeInfoPropertyName = "EvaluationRowCellType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DatasetRowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.DatasetRowCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.DatasetRowCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationRowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>), TypeInfoPropertyName = "OneOfDatasetRowCellEvaluationRowCell2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestLogDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestSuggestionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<int?, string>), TypeInfoPropertyName = "AnyOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDraftDatasetVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DraftDatasetVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddRequestLogToDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SaveDraftDatasetVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTraceToDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTraceToDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTraceToDatasetResponseMode), TypeInfoPropertyName = "AddTraceToDatasetResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Table))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Sheet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Column))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ColumnType), TypeInfoPropertyName = "ColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Cell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CellStatus), TypeInfoPropertyName = "CellStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SmartTableRequestMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperationSource), TypeInfoPropertyName = "TableImportOperationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperationStatus), TypeInfoPropertyName = "TableImportOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExecutionMetadataMetricAggregate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey), TypeInfoPropertyName = "ExecutionMetadataMetricAggregateMetricKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExecutionMetadataAggregates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::PromptLayer.ExecutionMetadataMetricAggregate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExecutionMetadataAggregatesSheet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetOperationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TableSheetOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationRequestOperation), TypeInfoPropertyName = "CreateTableSheetOperationRequestOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetOperationRequestStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationRequestStatuse), TypeInfoPropertyName = "CreateTableSheetOperationRequestStatuse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationResponse), TypeInfoPropertyName = "CreateTableSheetOperationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationNoopResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationConfirmationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CancelTableSheetOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreResponseScoringType), TypeInfoPropertyName = "TableSheetScoreResponseScoringType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScoreColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>), TypeInfoPropertyName = "OneOfDoubleStringTableSheetScoreCellObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreCellObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScoreMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreResponseStatus), TypeInfoPropertyName = "TableSheetScoreResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreResponseScoreType), TypeInfoPropertyName = "TableSheetScoreResponseScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScoreRequestScoreType), TypeInfoPropertyName = "ConfigureTableSheetScoreRequestScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage), TypeInfoPropertyName = "ConfigureTableSheetScoreRequestCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation), TypeInfoPropertyName = "ConfigureTableSheetScoreRequestAssertionAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RecalculateTableSheetScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RecalculateTableSheetScoreResponseStatus), TypeInfoPropertyName = "RecalculateTableSheetScoreResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TableSheetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PublicListPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EmptyPublicFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreHistoryResponseScoreHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution), TypeInfoPropertyName = "TableSheetScoreHistoryResponseScoreHistoryResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetFileImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetImportStartResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy), TypeInfoPropertyName = "CreateTableSheetRequestLogImportRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder), TypeInfoPropertyName = "CreateTableSheetRequestLogImportRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetOperationOperation), TypeInfoPropertyName = "TableSheetOperationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation), TypeInfoPropertyName = "CreateTableSheetOperationQueuedResponseOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TableCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreColumnResolvedScoringType), TypeInfoPropertyName = "TableSheetScoreColumnResolvedScoringType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreConfigurationScoreType), TypeInfoPropertyName = "TableSheetScoreConfigurationScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableCellStatus), TypeInfoPropertyName = "TableCellStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreatePromptLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnRequestColumnType), TypeInfoPropertyName = "AddReportColumnRequestColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunReportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolRegistryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolRegistryRequestExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolRegistryRequestExecutionType), TypeInfoPropertyName = "CreateToolRegistryRequestExecutionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolRegistryRequestExecutionLanguage), TypeInfoPropertyName = "CreateToolRegistryRequestExecutionLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>), TypeInfoPropertyName = "OneOfCreateTableSheetRequestSourceFileSourceCreateTableSheetRequestSourceRequestLogsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSource))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

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

            typeof(global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EntityTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EntityTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptEntityMetadataTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptEntityMetadataTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterFieldJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterFieldNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterOperatorJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterOperatorNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterGroupLogicJsonConverter),

            typeof(global::PromptLayer.JsonConverters.StructuredFilterGroupLogicNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListPromptTemplateItemPromptTemplateDiscriminatorTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListPromptTemplateItemPromptTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ReportColumnSummaryColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ReportColumnSummaryColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.DatasetRowCellTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.DatasetRowCellTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationRowCellTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.EvaluationRowCellTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CellStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CellStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableImportOperationSourceJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableImportOperationSourceNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableImportOperationStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableImportOperationStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestStatuseJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestStatuseNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetOperationOperationJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetOperationOperationNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableCellStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TableCellStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetColumnRequestTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetColumnRequestTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionLanguageJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionLanguageNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListDatasetsSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListEvaluationsSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListWorkflowsSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListWorkflowsSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListWorkflowsSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListWorkflowsSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2JsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2NullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingJsonConverter),

            typeof(global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetSkillCollectionPublicFormatJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetSkillCollectionPublicFormatNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListToolRegistriesSortByJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListToolRegistriesSortByNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListToolRegistriesSortOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListToolRegistriesSortOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTablesOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTablesOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetsOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetsOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetRowsOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetRowsOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetVersionsSortJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetVersionsSortNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetVersionsOrderJsonConverter),

            typeof(global::PromptLayer.JsonConverters.ListTableSheetVersionsOrderNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryRangeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryRangeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryResolutionJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryResolutionNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportResponseStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportResponseStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeJsonConverter),

            typeof(global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolResponseResultStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.TestExecuteToolResponseResultStatusNullableJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CloseTraceResponseClosureStatusJsonConverter),

            typeof(global::PromptLayer.JsonConverters.CloseTraceResponseClosureStatusNullableJsonConverter),

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

            typeof(global::PromptLayer.JsonConverters.SearchRequestLogsRequestJsonConverter),

            typeof(global::PromptLayer.JsonConverters.PromptTemplate6JsonConverter),

            typeof(global::PromptLayer.JsonConverters.CreateTableSheetOperationResponseJsonConverter),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.NodeUpdate, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.SkillCollectionVersion, object>),

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

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.DatasetGroup, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.Dataset, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<double?, string, global::PromptLayer.TableSheetScoreCellObject>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.FolderExistsError, string>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>),

            typeof(global::PromptLayer.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_a2e389e01f671d8d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>), TypeInfoPropertyName = "GetReportScoreResponseScoreDetailsVariant4_e167c334488aa373")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>?), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_47a8c666c2b64908")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>?), TypeInfoPropertyName = "GetReportScoreResponseScoreDetailsVariant4_819979ee8daaec57")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_13c51ceff6c2844e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSourceType), TypeInfoPropertyName = "CreateTableSheetRequestSourceFileSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType), TypeInfoPropertyName = "CreateTableSheetRequestSourceRequestLogsSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetColumnRequestType), TypeInfoPropertyName = "CreateTableSheetColumnRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetColumnRequestDependencie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetColumnRequestDependencie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetColumnRequestDependencie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTableSheetRowsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetCellRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetCellRecalculationsBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolVersionRequestExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolVersionRequestExecutionType), TypeInfoPropertyName = "CreateToolVersionRequestExecutionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolVersionRequestExecutionLanguage), TypeInfoPropertyName = "CreateToolVersionRequestExecutionLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TestExecuteToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TestExecuteToolRequestExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TestExecuteToolRequestExecutionType), TypeInfoPropertyName = "TestExecuteToolRequestExecutionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TestExecuteToolRequestExecutionLanguage), TypeInfoPropertyName = "TestExecuteToolRequestExecutionLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateWorkspaceEnvVarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateWorkspaceEnvVarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolEnvVarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateToolEnvVarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsStatus), TypeInfoPropertyName = "ListDatasetsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsSortBy), TypeInfoPropertyName = "ListDatasetsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsSortOrder), TypeInfoPropertyName = "ListDatasetsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListEvaluationsStatus), TypeInfoPropertyName = "ListEvaluationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListEvaluationsSortBy), TypeInfoPropertyName = "ListEvaluationsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListEvaluationsSortOrder), TypeInfoPropertyName = "ListEvaluationsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetAllPromptTemplatesGetStatus), TypeInfoPropertyName = "GetAllPromptTemplatesGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetAllPromptTemplatesGetSortBy), TypeInfoPropertyName = "GetAllPromptTemplatesGetSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetAllPromptTemplatesGetSortOrder), TypeInfoPropertyName = "GetAllPromptTemplatesGetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListWorkflowsSortBy), TypeInfoPropertyName = "ListWorkflowsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListWorkflowsSortOrder), TypeInfoPropertyName = "ListWorkflowsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.IngestOtlpTracesContentType), TypeInfoPropertyName = "IngestOtlpTracesContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.IngestOtlpTracesContentEncoding), TypeInfoPropertyName = "IngestOtlpTracesContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListSkillCollectionsPublicSortBy), TypeInfoPropertyName = "ListSkillCollectionsPublicSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListSkillCollectionsPublicSortOrder), TypeInfoPropertyName = "ListSkillCollectionsPublicSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetSkillCollectionPublicFormat), TypeInfoPropertyName = "GetSkillCollectionPublicFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetRequestSearchSuggestionsField), TypeInfoPropertyName = "GetRequestSearchSuggestionsField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListToolRegistriesSortBy), TypeInfoPropertyName = "ListToolRegistriesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListToolRegistriesSortOrder), TypeInfoPropertyName = "ListToolRegistriesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTablesOrder), TypeInfoPropertyName = "ListTablesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetsOrder), TypeInfoPropertyName = "ListTableSheetsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetRowsOrder), TypeInfoPropertyName = "ListTableSheetRowsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetVersionsSort), TypeInfoPropertyName = "ListTableSheetVersionsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetVersionsOrder), TypeInfoPropertyName = "ListTableSheetVersionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryRange), TypeInfoPropertyName = "GetTableSheetVersionScoreHistoryRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryResolution), TypeInfoPropertyName = "GetTableSheetVersionScoreHistoryResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>), TypeInfoPropertyName = "OneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreatePromptLabelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TrackScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteReportsByNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateEvaluationPipelineResponse2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetReportResponseReportColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportResponseReportColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreScoreType), TypeInfoPropertyName = "GetReportScoreResponseScoreScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListEvaluationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Evaluation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.IngestOtlpTracesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListToolRegistriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListToolRegistriesResponseToolRegistrie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListToolRegistriesResponseToolRegistrie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetToolRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetToolRegistryResponseToolRegistry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Sheet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetOperationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetColumnsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetColumnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetColumnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetRowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListTableSheetRowsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetRowsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::PromptLayer.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTableSheetRowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.AddTableSheetRowsResponseRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTableSheetRowsResponseRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetCellResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetCellResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetCellRecalculationsBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetCellRecalculationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TestExecuteToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TestExecuteToolResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TestExecuteToolResponseResultStatus), TypeInfoPropertyName = "TestExecuteToolResponseResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponseClosure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponseClosureStatus), TypeInfoPropertyName = "CloseTraceResponseClosureStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListWorkspaceEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListWorkspaceEnvVarsResponseWorkspaceEnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListWorkspaceEnvVarsResponseWorkspaceEnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateWorkspaceEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateWorkspaceEnvVarResponseWorkspaceEnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateWorkspaceEnvVarResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateWorkspaceEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateWorkspaceEnvVarResponseWorkspaceEnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateWorkspaceEnvVarResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteWorkspaceEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteWorkspaceEnvVarResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListToolEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListToolEnvVarsResponseToolEnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListToolEnvVarsResponseToolEnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListToolEnvVarsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolEnvVarResponseToolEnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolEnvVarResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateToolEnvVarResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateToolEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateToolEnvVarResponseToolEnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateToolEnvVarResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteToolEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteToolEnvVarResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.EvaluationRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ExternalId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetSnippetUsageResponseLabelUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.EdgeConditional>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.WorkflowNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CreateWorkflowResponseNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.InitialFileUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.FileUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.FileMove>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.SkillCollection>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListPromptTemplateItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseMostUsedPromptTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseErrorType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsBreakdownEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseMetadataKeysTopItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseOutputKeysTopItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsToolLatency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseToolsUsageBar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseMetadataValueBreakdownItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.RequestLogSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.EvaluationColumnDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ReportColumnSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.DatasetRowCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.DatasetRowCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CreateTableSheetOperationRequestStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetScoreColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetScoreMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CreateTableSheetColumnRequestDependencie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetReportResponseReportColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Evaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListWorkflowsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListToolRegistriesResponseToolRegistrie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Sheet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListTableSheetRowsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AddTableSheetRowsResponseRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListWorkspaceEnvVarsResponseWorkspaceEnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListToolEnvVarsResponseToolEnvVar>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::PromptLayer.JsonConverters.EvaluationRunStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EvaluationRunStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EdgeConditionalOperatorJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EdgeConditionalOperatorNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetPromptTemplateProvider2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetPromptTemplateProvider2NullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CompletionPromptContentItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CompletionPromptContentItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CompletionPromptTemplateFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CompletionPromptTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CompletionPromptTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CompletionPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TextContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TextContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ThinkingContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ThinkingContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.MediaFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.MediaFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ImageContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ImageContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.MediaContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.MediaContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.MediaVariableTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.MediaVariableTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OutputMediaContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OutputMediaContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OutputMediaContentMediaTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OutputMediaContentMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CodeContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CodeContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ServerToolUseContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ServerToolUseContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.WebSearchResultTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.WebSearchResultTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CodeExecutionResultContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CodeExecutionResultContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.McpListToolsContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.McpListToolsContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.McpCallContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.McpCallContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.McpApprovalRequestContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.McpApprovalRequestContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.McpApprovalResponseContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.McpApprovalResponseContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.BashCodeExecutionToolResultContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.BashCodeExecutionToolResultContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ShellCallContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ShellCallContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ShellCallOutputContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ShellCallOutputContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ApplyPatchCallContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ApplyPatchCallContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ApplyPatchCallOutputContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ApplyPatchCallOutputContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.BuiltInToolTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.BuiltInToolTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.SystemMessageTemplateFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.SystemMessageTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.SystemMessageContentItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.SystemMessageContentItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UserMessageTemplateFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UserMessageTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UserMessageContentItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UserMessageContentItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AssistantMessageTemplateFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AssistantMessageTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.FunctionMessageTemplateFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.FunctionMessageTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.DeveloperMessageTemplateFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.DeveloperMessageTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ChatPromptMessageDiscriminatorRoleJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ChatPromptMessageDiscriminatorRoleNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ChatPromptTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ChatPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptVersionPromptTemplateDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptVersionPromptTemplateDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ToolMessageTemplateFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ToolMessageTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ToolMessageContentItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ToolMessageContentItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ToolDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PlaceholderMessageTemplateFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PlaceholderMessageTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PlaceholderMessageRoleJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PlaceholderMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestInputDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestInputDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestOutputDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestOutputDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestErrorType2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestErrorType2NullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestResponseStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.LogRequestResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.SpanKindJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.SpanKindNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.StatusCodeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.StatusCodeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EntityTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EntityTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptEntityMetadataTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptEntityMetadataTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.RequestLogQuerySortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.RequestLogQuerySortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.RequestLogQuerySortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.RequestLogQuerySortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.StructuredFilterFieldJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.StructuredFilterFieldNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.StructuredFilterOperatorJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.StructuredFilterOperatorNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.StructuredFilterGroupLogicJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.StructuredFilterGroupLogicNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListPromptTemplateItemPromptTemplateDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListPromptTemplateItemPromptTemplateDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ReportColumnSummaryColumnTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ReportColumnSummaryColumnTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.DatasetRowCellTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.DatasetRowCellTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EvaluationRowCellTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.EvaluationRowCellTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ColumnTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ColumnTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CellStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CellStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableImportOperationSourceJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableImportOperationSourceNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableImportOperationStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableImportOperationStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestStatuseJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestStatuseNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetOperationOperationJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetOperationOperationNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableCellStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TableCellStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionLanguageJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateToolRegistryRequestExecutionLanguageNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetColumnRequestTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetColumnRequestTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionLanguageJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateToolVersionRequestExecutionLanguageNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionLanguageJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TestExecuteToolRequestExecutionLanguageNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListDatasetsStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListDatasetsStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListDatasetsSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListDatasetsSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListDatasetsSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListDatasetsSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListEvaluationsStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListEvaluationsStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListEvaluationsSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListEvaluationsSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListEvaluationsSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListEvaluationsSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetAllPromptTemplatesGetSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListWorkflowsSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListWorkflowsSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListWorkflowsSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListWorkflowsSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2NullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.IngestOtlpTracesContentTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.IngestOtlpTracesContentEncodingNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListSkillCollectionsPublicSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetSkillCollectionPublicFormatJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetSkillCollectionPublicFormatNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListToolRegistriesSortByJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListToolRegistriesSortByNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListToolRegistriesSortOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListToolRegistriesSortOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTablesOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTablesOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTableSheetsOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTableSheetsOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTableSheetRowsOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTableSheetRowsOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTableSheetVersionsSortJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTableSheetVersionsSortNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTableSheetVersionsOrderJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ListTableSheetVersionsOrderNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryRangeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryRangeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryResolutionJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryResolutionNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetReportResponseStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetReportResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TestExecuteToolResponseResultStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.TestExecuteToolResponseResultStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CloseTraceResponseClosureStatusJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CloseTraceResponseClosureStatusNullableJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItemJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItem2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItem3JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentVariant1ItemJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentVariant1Item2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItem4JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.MessagesItemJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplateJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate3JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate4JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItem5JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentVariant1Item3JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.InputJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OutputJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate5JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.SearchRequestLogsRequestJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate6JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetOperationResponseJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.NodeUpdate, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.SkillCollectionVersion, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.MessageFunctionCall, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.ChatToolChoice, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<string, double?, bool?, byte[], object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.DatasetGroup, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.Dataset, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<double?, string, global::PromptLayer.TableSheetScoreCellObject>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.FolderExistsError, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}