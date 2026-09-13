
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestLogDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestSuggestionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DerivedRatioInsightSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DerivedRatioInsightSpecType), TypeInfoPropertyName = "DerivedRatioInsightSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DerivedRatioInsightResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DerivedRatioInsightResultType), TypeInfoPropertyName = "DerivedRatioInsightResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpecChartType), TypeInfoPropertyName = "CustomAnalyticsSpecChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpecMetric), TypeInfoPropertyName = "CustomAnalyticsSpecMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpecMetricField), TypeInfoPropertyName = "CustomAnalyticsSpecMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSeriesSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSeriesSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.DerivedRatioInsightSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpecGroupByField), TypeInfoPropertyName = "CustomAnalyticsSpecGroupByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetric), TypeInfoPropertyName = "CustomAnalyticsSeriesSpecMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetricField), TypeInfoPropertyName = "CustomAnalyticsSeriesSpecMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSeriesMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSeriesMetaUnit), TypeInfoPropertyName = "CustomAnalyticsSeriesMetaUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsResultChartType), TypeInfoPropertyName = "CustomAnalyticsResultChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSeriesMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.DerivedRatioInsightResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy), TypeInfoPropertyName = "RequestAnalyticsCustomAnalyticsQuerySortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder), TypeInfoPropertyName = "RequestAnalyticsCustomAnalyticsQuerySortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceStructuredFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceStructuredFilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceStructuredFilterGroupLogic), TypeInfoPropertyName = "TraceStructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>), TypeInfoPropertyName = "OneOfTraceStructuredFilterTraceStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecChartType), TypeInfoPropertyName = "TraceCustomChartSpecChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecMetric), TypeInfoPropertyName = "TraceCustomChartSpecMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecMetricField), TypeInfoPropertyName = "TraceCustomChartSpecMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecGroupByField), TypeInfoPropertyName = "TraceCustomChartSpecGroupByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField), TypeInfoPropertyName = "TraceCustomChartSpecSecondaryGroupByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecHistogramField), TypeInfoPropertyName = "TraceCustomChartSpecHistogramField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpecHierarchyField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecHierarchyField), TypeInfoPropertyName = "TraceCustomChartSpecHierarchyField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecTimeBucket), TypeInfoPropertyName = "TraceCustomChartSpecTimeBucket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpecSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecSerieMetric), TypeInfoPropertyName = "TraceCustomChartSpecSerieMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecSerieMetricField), TypeInfoPropertyName = "TraceCustomChartSpecSerieMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceAnalyticsCustomAnalyticsQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetRequestSearchSuggestionsField), TypeInfoPropertyName = "GetRequestSearchSuggestionsField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>), TypeInfoPropertyName = "OneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponseClosure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponseClosureStatus), TypeInfoPropertyName = "CloseTraceResponseClosureStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestLogQuerySortBy?), TypeInfoPropertyName = "NullableRequestLogQuerySortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestLogQuerySortOrder?), TypeInfoPropertyName = "NullableRequestLogQuerySortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SearchRequestLogsRequest?), TypeInfoPropertyName = "NullableSearchRequestLogsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterField?), TypeInfoPropertyName = "NullableStructuredFilterField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterOperator?), TypeInfoPropertyName = "NullableStructuredFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, double?, bool?, byte[], object>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanByteArrayObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroupLogic?), TypeInfoPropertyName = "NullableStructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>?), TypeInfoPropertyName = "NullableOneOfStructuredFilterStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DerivedRatioInsightSpecType?), TypeInfoPropertyName = "NullableDerivedRatioInsightSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DerivedRatioInsightResultType?), TypeInfoPropertyName = "NullableDerivedRatioInsightResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpecChartType?), TypeInfoPropertyName = "NullableCustomAnalyticsSpecChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpecMetric?), TypeInfoPropertyName = "NullableCustomAnalyticsSpecMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpecMetricField?), TypeInfoPropertyName = "NullableCustomAnalyticsSpecMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSpecGroupByField?), TypeInfoPropertyName = "NullableCustomAnalyticsSpecGroupByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetric?), TypeInfoPropertyName = "NullableCustomAnalyticsSeriesSpecMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetricField?), TypeInfoPropertyName = "NullableCustomAnalyticsSeriesSpecMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsSeriesMetaUnit?), TypeInfoPropertyName = "NullableCustomAnalyticsSeriesMetaUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CustomAnalyticsResultChartType?), TypeInfoPropertyName = "NullableCustomAnalyticsResultChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy?), TypeInfoPropertyName = "NullableRequestAnalyticsCustomAnalyticsQuerySortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder?), TypeInfoPropertyName = "NullableRequestAnalyticsCustomAnalyticsQuerySortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceStructuredFilterGroupLogic?), TypeInfoPropertyName = "NullableTraceStructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>?), TypeInfoPropertyName = "NullableOneOfTraceStructuredFilterTraceStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecChartType?), TypeInfoPropertyName = "NullableTraceCustomChartSpecChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecMetric?), TypeInfoPropertyName = "NullableTraceCustomChartSpecMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecMetricField?), TypeInfoPropertyName = "NullableTraceCustomChartSpecMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecGroupByField?), TypeInfoPropertyName = "NullableTraceCustomChartSpecGroupByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField?), TypeInfoPropertyName = "NullableTraceCustomChartSpecSecondaryGroupByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecHistogramField?), TypeInfoPropertyName = "NullableTraceCustomChartSpecHistogramField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecHierarchyField?), TypeInfoPropertyName = "NullableTraceCustomChartSpecHierarchyField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecTimeBucket?), TypeInfoPropertyName = "NullableTraceCustomChartSpecTimeBucket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecSerieMetric?), TypeInfoPropertyName = "NullableTraceCustomChartSpecSerieMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TraceCustomChartSpecSerieMetricField?), TypeInfoPropertyName = "NullableTraceCustomChartSpecSerieMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetRequestSearchSuggestionsField?), TypeInfoPropertyName = "NullableGetRequestSearchSuggestionsField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>?), TypeInfoPropertyName = "NullableOneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CloseTraceResponseClosureStatus?), TypeInfoPropertyName = "NullableCloseTraceResponseClosureStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CustomAnalyticsSeriesSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.DerivedRatioInsightSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CustomAnalyticsSeriesMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.DerivedRatioInsightResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CustomAnalyticsSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CustomAnalyticsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TraceCustomChartSpecHierarchyField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TraceCustomChartSpecSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.TraceCustomChartSpec>))]
    internal sealed partial class TrackingSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TrackingSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TrackingSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::PromptLayer.JsonConverters.SearchRequestLogsRequestJsonConverter());
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
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
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
                    typeToConvert == typeof(global::PromptLayer.RequestLogQuerySortBy)

                    || typeToConvert == typeof(global::PromptLayer.RequestLogQuerySortBy?)

                    || typeToConvert == typeof(global::PromptLayer.RequestLogQuerySortOrder)

                    || typeToConvert == typeof(global::PromptLayer.RequestLogQuerySortOrder?)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterField)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterField?)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterOperator)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterOperator?)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterGroupLogic)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterGroupLogic?)

                    || typeToConvert == typeof(global::PromptLayer.DerivedRatioInsightSpecType)

                    || typeToConvert == typeof(global::PromptLayer.DerivedRatioInsightSpecType?)

                    || typeToConvert == typeof(global::PromptLayer.DerivedRatioInsightResultType)

                    || typeToConvert == typeof(global::PromptLayer.DerivedRatioInsightResultType?)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecChartType)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecChartType?)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecMetric)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecMetric?)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecMetricField)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecMetricField?)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecGroupByField)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecGroupByField?)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetric)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetric?)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetricField)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetricField?)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesMetaUnit)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesMetaUnit?)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsResultChartType)

                    || typeToConvert == typeof(global::PromptLayer.CustomAnalyticsResultChartType?)

                    || typeToConvert == typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy)

                    || typeToConvert == typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy?)

                    || typeToConvert == typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder)

                    || typeToConvert == typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder?)

                    || typeToConvert == typeof(global::PromptLayer.TraceStructuredFilterGroupLogic)

                    || typeToConvert == typeof(global::PromptLayer.TraceStructuredFilterGroupLogic?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecChartType)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecChartType?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecMetric)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecMetric?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecMetricField)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecMetricField?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecGroupByField)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecGroupByField?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecHistogramField)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecHistogramField?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecHierarchyField)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecHierarchyField?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecTimeBucket)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecTimeBucket?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSerieMetric)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSerieMetric?)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSerieMetricField)

                    || typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSerieMetricField?)

                    || typeToConvert == typeof(global::PromptLayer.GetRequestSearchSuggestionsField)

                    || typeToConvert == typeof(global::PromptLayer.GetRequestSearchSuggestionsField?)

                    || typeToConvert == typeof(global::PromptLayer.CloseTraceResponseClosureStatus)

                    || typeToConvert == typeof(global::PromptLayer.CloseTraceResponseClosureStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::PromptLayer.RequestLogQuerySortBy))
                {
                    return new global::PromptLayer.JsonConverters.RequestLogQuerySortByJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RequestLogQuerySortBy?))
                {
                    return new global::PromptLayer.JsonConverters.RequestLogQuerySortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RequestLogQuerySortOrder))
                {
                    return new global::PromptLayer.JsonConverters.RequestLogQuerySortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RequestLogQuerySortOrder?))
                {
                    return new global::PromptLayer.JsonConverters.RequestLogQuerySortOrderNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::PromptLayer.DerivedRatioInsightSpecType))
                {
                    return new global::PromptLayer.JsonConverters.DerivedRatioInsightSpecTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DerivedRatioInsightSpecType?))
                {
                    return new global::PromptLayer.JsonConverters.DerivedRatioInsightSpecTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DerivedRatioInsightResultType))
                {
                    return new global::PromptLayer.JsonConverters.DerivedRatioInsightResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DerivedRatioInsightResultType?))
                {
                    return new global::PromptLayer.JsonConverters.DerivedRatioInsightResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecChartType))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSpecChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecChartType?))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSpecChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecMetric))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSpecMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecMetric?))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSpecMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecMetricField))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSpecMetricFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecMetricField?))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSpecMetricFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecGroupByField))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSpecGroupByFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSpecGroupByField?))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSpecGroupByFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetric))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSeriesSpecMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetric?))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSeriesSpecMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetricField))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSeriesSpecMetricFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesSpecMetricField?))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSeriesSpecMetricFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesMetaUnit))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSeriesMetaUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsSeriesMetaUnit?))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsSeriesMetaUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsResultChartType))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsResultChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CustomAnalyticsResultChartType?))
                {
                    return new global::PromptLayer.JsonConverters.CustomAnalyticsResultChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy))
                {
                    return new global::PromptLayer.JsonConverters.RequestAnalyticsCustomAnalyticsQuerySortByJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy?))
                {
                    return new global::PromptLayer.JsonConverters.RequestAnalyticsCustomAnalyticsQuerySortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder))
                {
                    return new global::PromptLayer.JsonConverters.RequestAnalyticsCustomAnalyticsQuerySortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder?))
                {
                    return new global::PromptLayer.JsonConverters.RequestAnalyticsCustomAnalyticsQuerySortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceStructuredFilterGroupLogic))
                {
                    return new global::PromptLayer.JsonConverters.TraceStructuredFilterGroupLogicJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceStructuredFilterGroupLogic?))
                {
                    return new global::PromptLayer.JsonConverters.TraceStructuredFilterGroupLogicNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecChartType))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecChartType?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecMetric))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecMetric?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecMetricField))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecMetricFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecMetricField?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecMetricFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecGroupByField))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecGroupByFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecGroupByField?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecGroupByFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecSecondaryGroupByFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecSecondaryGroupByFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecHistogramField))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecHistogramFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecHistogramField?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecHistogramFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecHierarchyField))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecHierarchyFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecHierarchyField?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecHierarchyFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecTimeBucket))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecTimeBucketJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecTimeBucket?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecTimeBucketNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSerieMetric))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecSerieMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSerieMetric?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecSerieMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSerieMetricField))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecSerieMetricFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TraceCustomChartSpecSerieMetricField?))
                {
                    return new global::PromptLayer.JsonConverters.TraceCustomChartSpecSerieMetricFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetRequestSearchSuggestionsField))
                {
                    return new global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetRequestSearchSuggestionsField?))
                {
                    return new global::PromptLayer.JsonConverters.GetRequestSearchSuggestionsFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CloseTraceResponseClosureStatus))
                {
                    return new global::PromptLayer.JsonConverters.CloseTraceResponseClosureStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CloseTraceResponseClosureStatus?))
                {
                    return new global::PromptLayer.JsonConverters.CloseTraceResponseClosureStatusNullableJsonConverter();
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
                    0 => new TrackingSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}