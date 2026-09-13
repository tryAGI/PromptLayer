
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterField), TypeInfoPropertyName = "StructuredFilterField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterOperator), TypeInfoPropertyName = "StructuredFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, double?, bool?, byte[], object>), TypeInfoPropertyName = "OneOfStringDoubleBooleanByteArrayObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroupLogic), TypeInfoPropertyName = "StructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>), TypeInfoPropertyName = "OneOfStructuredFilterStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperationSource), TypeInfoPropertyName = "TableImportOperationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperationStatus), TypeInfoPropertyName = "TableImportOperationStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardStaleState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardAggregation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior), TypeInfoPropertyName = "TableSheetScorecardAggregationRequiredStepFailureBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardStepPrimitiveType), TypeInfoPropertyName = "TableSheetScorecardStepPrimitiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardStepEvidenceMode), TypeInfoPropertyName = "TableSheetScorecardStepEvidenceMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardStatus), TypeInfoPropertyName = "TableSheetScorecardStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardCalculation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardCalculationStatus), TypeInfoPropertyName = "TableSheetScorecardCalculationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict), TypeInfoPropertyName = "TableSheetScorecardCalculationAggregateVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardGetResponseProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScorecardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScorecardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteTableSheetScorecardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MigrateLegacyTableSheetScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MigrateLegacyTableSheetScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.MigrateLegacyTableSheetScoreResponseSkippedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MigrateLegacyTableSheetScoreResponseSkippedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RecalculateTableSheetScorecardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RecalculateTableSheetScorecardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RecalculateTableSheetScorecardResponseStatus), TypeInfoPropertyName = "RecalculateTableSheetScorecardResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CancelTableSheetScorecardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CancelTableSheetScorecardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CancelTableSheetScorecardResponseScorecard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetScorecardCalculationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardRowSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict), TypeInfoPropertyName = "TableSheetScorecardRowSummaryAggregateVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetScorecardRowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardRowSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetScorecardRowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict), TypeInfoPropertyName = "GetTableSheetScorecardRowResponseAggregateVerdict2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetScorecardRowsVerdict), TypeInfoPropertyName = "ListTableSheetScorecardRowsVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetVersionsSort), TypeInfoPropertyName = "ListTableSheetVersionsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetVersionsOrder), TypeInfoPropertyName = "ListTableSheetVersionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryRange), TypeInfoPropertyName = "GetTableSheetVersionScoreHistoryRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryResolution), TypeInfoPropertyName = "GetTableSheetVersionScoreHistoryResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterField?), TypeInfoPropertyName = "NullableStructuredFilterField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterOperator?), TypeInfoPropertyName = "NullableStructuredFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, double?, bool?, byte[], object>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanByteArrayObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroupLogic?), TypeInfoPropertyName = "NullableStructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>?), TypeInfoPropertyName = "NullableOneOfStructuredFilterStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperationSource?), TypeInfoPropertyName = "NullableTableImportOperationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperationStatus?), TypeInfoPropertyName = "NullableTableImportOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationRequestOperation?), TypeInfoPropertyName = "NullableCreateTableSheetOperationRequestOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationRequestStatuse?), TypeInfoPropertyName = "NullableCreateTableSheetOperationRequestStatuse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationResponse?), TypeInfoPropertyName = "NullableCreateTableSheetOperationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreResponseScoringType?), TypeInfoPropertyName = "NullableTableSheetScoreResponseScoringType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?), TypeInfoPropertyName = "NullableOneOfDoubleStringTableSheetScoreCellObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreResponseStatus?), TypeInfoPropertyName = "NullableTableSheetScoreResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreResponseScoreType?), TypeInfoPropertyName = "NullableTableSheetScoreResponseScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScoreRequestScoreType?), TypeInfoPropertyName = "NullableConfigureTableSheetScoreRequestScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage?), TypeInfoPropertyName = "NullableConfigureTableSheetScoreRequestCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation?), TypeInfoPropertyName = "NullableConfigureTableSheetScoreRequestAssertionAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RecalculateTableSheetScoreResponseStatus?), TypeInfoPropertyName = "NullableRecalculateTableSheetScoreResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior?), TypeInfoPropertyName = "NullableTableSheetScorecardAggregationRequiredStepFailureBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardStepPrimitiveType?), TypeInfoPropertyName = "NullableTableSheetScorecardStepPrimitiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardStepEvidenceMode?), TypeInfoPropertyName = "NullableTableSheetScorecardStepEvidenceMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardStatus?), TypeInfoPropertyName = "NullableTableSheetScorecardStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardCalculationStatus?), TypeInfoPropertyName = "NullableTableSheetScorecardCalculationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict?), TypeInfoPropertyName = "NullableTableSheetScorecardCalculationAggregateVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RecalculateTableSheetScorecardResponseStatus?), TypeInfoPropertyName = "NullableRecalculateTableSheetScorecardResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict?), TypeInfoPropertyName = "NullableTableSheetScorecardRowSummaryAggregateVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict?), TypeInfoPropertyName = "NullableGetTableSheetScorecardRowResponseAggregateVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution?), TypeInfoPropertyName = "NullableTableSheetScoreHistoryResponseScoreHistoryResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy?), TypeInfoPropertyName = "NullableCreateTableSheetRequestLogImportRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder?), TypeInfoPropertyName = "NullableCreateTableSheetRequestLogImportRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetOperationOperation?), TypeInfoPropertyName = "NullableTableSheetOperationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation?), TypeInfoPropertyName = "NullableCreateTableSheetOperationQueuedResponseOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreColumnResolvedScoringType?), TypeInfoPropertyName = "NullableTableSheetScoreColumnResolvedScoringType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableSheetScoreConfigurationScoreType?), TypeInfoPropertyName = "NullableTableSheetScoreConfigurationScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableCellStatus?), TypeInfoPropertyName = "NullableTableCellStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetScorecardRowsVerdict?), TypeInfoPropertyName = "NullableListTableSheetScorecardRowsVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetVersionsSort?), TypeInfoPropertyName = "NullableListTableSheetVersionsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetVersionsOrder?), TypeInfoPropertyName = "NullableListTableSheetVersionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryRange?), TypeInfoPropertyName = "NullableGetTableSheetVersionScoreHistoryRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryResolution?), TypeInfoPropertyName = "NullableGetTableSheetVersionScoreHistoryResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CreateTableSheetOperationRequestStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetScoreColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetScoreMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetScorecardStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.MigrateLegacyTableSheetScoreResponseSkippedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetScorecardRowSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableSheetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TableCell>))]
    internal sealed partial class TablesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TablesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TablesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TablesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::PromptLayer.JsonConverters.CreateTableSheetOperationResponseJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<string, double?, bool?, byte[], object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<double?, string, global::PromptLayer.TableSheetScoreCellObject>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::PromptLayer.StructuredFilterField)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterField?)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterOperator)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterOperator?)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterGroupLogic)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterGroupLogic?)

                    || typeToConvert == typeof(global::PromptLayer.TableImportOperationSource)

                    || typeToConvert == typeof(global::PromptLayer.TableImportOperationSource?)

                    || typeToConvert == typeof(global::PromptLayer.TableImportOperationStatus)

                    || typeToConvert == typeof(global::PromptLayer.TableImportOperationStatus?)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationRequestOperation)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationRequestOperation?)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationRequestStatuse)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationRequestStatuse?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseScoringType)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseScoringType?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseStatus)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseStatus?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseScoreType)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseScoreType?)

                    || typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestScoreType)

                    || typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestScoreType?)

                    || typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage)

                    || typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage?)

                    || typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation)

                    || typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation?)

                    || typeToConvert == typeof(global::PromptLayer.RecalculateTableSheetScoreResponseStatus)

                    || typeToConvert == typeof(global::PromptLayer.RecalculateTableSheetScoreResponseStatus?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStepPrimitiveType)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStepPrimitiveType?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStepEvidenceMode)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStepEvidenceMode?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStatus)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStatus?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardCalculationStatus)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardCalculationStatus?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict?)

                    || typeToConvert == typeof(global::PromptLayer.RecalculateTableSheetScorecardResponseStatus)

                    || typeToConvert == typeof(global::PromptLayer.RecalculateTableSheetScorecardResponseStatus?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict?)

                    || typeToConvert == typeof(global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict)

                    || typeToConvert == typeof(global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution?)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy?)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetOperationOperation)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetOperationOperation?)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreColumnResolvedScoringType)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreColumnResolvedScoringType?)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreConfigurationScoreType)

                    || typeToConvert == typeof(global::PromptLayer.TableSheetScoreConfigurationScoreType?)

                    || typeToConvert == typeof(global::PromptLayer.TableCellStatus)

                    || typeToConvert == typeof(global::PromptLayer.TableCellStatus?)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetScorecardRowsVerdict)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetScorecardRowsVerdict?)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetVersionsSort)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetVersionsSort?)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetVersionsOrder)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetVersionsOrder?)

                    || typeToConvert == typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryRange)

                    || typeToConvert == typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryRange?)

                    || typeToConvert == typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryResolution)

                    || typeToConvert == typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryResolution?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::PromptLayer.StructuredFilterField))
                {
                    return new global::PromptLayer.JsonConverters.StructuredFilterFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.StructuredFilterField?))
                {
                    return new global::PromptLayer.JsonConverters.StructuredFilterFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.StructuredFilterOperator))
                {
                    return new global::PromptLayer.JsonConverters.StructuredFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.StructuredFilterOperator?))
                {
                    return new global::PromptLayer.JsonConverters.StructuredFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.StructuredFilterGroupLogic))
                {
                    return new global::PromptLayer.JsonConverters.StructuredFilterGroupLogicJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.StructuredFilterGroupLogic?))
                {
                    return new global::PromptLayer.JsonConverters.StructuredFilterGroupLogicNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableImportOperationSource))
                {
                    return new global::PromptLayer.JsonConverters.TableImportOperationSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableImportOperationSource?))
                {
                    return new global::PromptLayer.JsonConverters.TableImportOperationSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableImportOperationStatus))
                {
                    return new global::PromptLayer.JsonConverters.TableImportOperationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableImportOperationStatus?))
                {
                    return new global::PromptLayer.JsonConverters.TableImportOperationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationRequestOperation))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationRequestOperation?))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationRequestStatuse))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestStatuseJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationRequestStatuse?))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetOperationRequestStatuseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseScoringType))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseScoringType?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreResponseScoringTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseStatus))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseStatus?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseScoreType))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreResponseScoreType?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreResponseScoreTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestScoreType))
                {
                    return new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestScoreType?))
                {
                    return new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage))
                {
                    return new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage?))
                {
                    return new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation))
                {
                    return new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation?))
                {
                    return new global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RecalculateTableSheetScoreResponseStatus))
                {
                    return new global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RecalculateTableSheetScoreResponseStatus?))
                {
                    return new global::PromptLayer.JsonConverters.RecalculateTableSheetScoreResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardAggregationRequiredStepFailureBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardAggregationRequiredStepFailureBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStepPrimitiveType))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardStepPrimitiveTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStepPrimitiveType?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardStepPrimitiveTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStepEvidenceMode))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardStepEvidenceModeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStepEvidenceMode?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardStepEvidenceModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStatus))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardStatus?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardCalculationStatus))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardCalculationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardCalculationStatus?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardCalculationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardCalculationAggregateVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardCalculationAggregateVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RecalculateTableSheetScorecardResponseStatus))
                {
                    return new global::PromptLayer.JsonConverters.RecalculateTableSheetScorecardResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RecalculateTableSheetScorecardResponseStatus?))
                {
                    return new global::PromptLayer.JsonConverters.RecalculateTableSheetScorecardResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardRowSummaryAggregateVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScorecardRowSummaryAggregateVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict))
                {
                    return new global::PromptLayer.JsonConverters.GetTableSheetScorecardRowResponseAggregateVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict?))
                {
                    return new global::PromptLayer.JsonConverters.GetTableSheetScorecardRowResponseAggregateVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy?))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder?))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetOperationOperation))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetOperationOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetOperationOperation?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetOperationOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation?))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetOperationQueuedResponseOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreColumnResolvedScoringType))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreColumnResolvedScoringType?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreConfigurationScoreType))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableSheetScoreConfigurationScoreType?))
                {
                    return new global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableCellStatus))
                {
                    return new global::PromptLayer.JsonConverters.TableCellStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableCellStatus?))
                {
                    return new global::PromptLayer.JsonConverters.TableCellStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetScorecardRowsVerdict))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetScorecardRowsVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetScorecardRowsVerdict?))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetScorecardRowsVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetVersionsSort))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetVersionsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetVersionsSort?))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetVersionsSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetVersionsOrder))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetVersionsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetVersionsOrder?))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetVersionsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryRange))
                {
                    return new global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryRange?))
                {
                    return new global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryResolution))
                {
                    return new global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetTableSheetVersionScoreHistoryResolution?))
                {
                    return new global::PromptLayer.JsonConverters.GetTableSheetVersionScoreHistoryResolutionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new TablesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}