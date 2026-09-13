
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>), TypeInfoPropertyName = "GetReportScoreResponseScoreDetailsVariant4_e167c334488aa373")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3, global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4>?), TypeInfoPropertyName = "GetReportScoreResponseScoreDetailsVariant4_819979ee8daaec57")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalIdErrorResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnRequestColumnType), TypeInfoPropertyName = "AddReportColumnRequestColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.RunReportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>), TypeInfoPropertyName = "OneOfHTTPValidationErrorErrorResponse2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EvaluationColumnDefinitionColumnType?), TypeInfoPropertyName = "NullableEvaluationColumnDefinitionColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ScoreConfigurationCodeLanguage?), TypeInfoPropertyName = "NullableScoreConfigurationCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ReportColumnSummaryColumnType?), TypeInfoPropertyName = "NullableReportColumnSummaryColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage?), TypeInfoPropertyName = "NullableUpdateReportScoreCardRequestCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EditReportColumnRequestColumnType?), TypeInfoPropertyName = "NullableEditReportColumnRequestColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddReportColumnRequestColumnType?), TypeInfoPropertyName = "NullableAddReportColumnRequestColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>?), TypeInfoPropertyName = "NullableOneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportResponseStatus?), TypeInfoPropertyName = "NullableGetReportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetReportScoreResponseScoreScoreType?), TypeInfoPropertyName = "NullableGetReportScoreResponseScoreScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ExternalId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.EvaluationColumnDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ReportColumnSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetReportResponseReportColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>))]
    internal sealed partial class ReportsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReportsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ReportsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ReportsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
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
                    typeToConvert == typeof(global::PromptLayer.EvaluationColumnDefinitionColumnType)

                    || typeToConvert == typeof(global::PromptLayer.EvaluationColumnDefinitionColumnType?)

                    || typeToConvert == typeof(global::PromptLayer.ScoreConfigurationCodeLanguage)

                    || typeToConvert == typeof(global::PromptLayer.ScoreConfigurationCodeLanguage?)

                    || typeToConvert == typeof(global::PromptLayer.ReportColumnSummaryColumnType)

                    || typeToConvert == typeof(global::PromptLayer.ReportColumnSummaryColumnType?)

                    || typeToConvert == typeof(global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage)

                    || typeToConvert == typeof(global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage?)

                    || typeToConvert == typeof(global::PromptLayer.EditReportColumnRequestColumnType)

                    || typeToConvert == typeof(global::PromptLayer.EditReportColumnRequestColumnType?)

                    || typeToConvert == typeof(global::PromptLayer.AddReportColumnRequestColumnType)

                    || typeToConvert == typeof(global::PromptLayer.AddReportColumnRequestColumnType?)

                    || typeToConvert == typeof(global::PromptLayer.GetReportResponseStatus)

                    || typeToConvert == typeof(global::PromptLayer.GetReportResponseStatus?)

                    || typeToConvert == typeof(global::PromptLayer.GetReportScoreResponseScoreScoreType)

                    || typeToConvert == typeof(global::PromptLayer.GetReportScoreResponseScoreScoreType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::PromptLayer.EvaluationColumnDefinitionColumnType))
                {
                    return new global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.EvaluationColumnDefinitionColumnType?))
                {
                    return new global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ScoreConfigurationCodeLanguage))
                {
                    return new global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ScoreConfigurationCodeLanguage?))
                {
                    return new global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ReportColumnSummaryColumnType))
                {
                    return new global::PromptLayer.JsonConverters.ReportColumnSummaryColumnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ReportColumnSummaryColumnType?))
                {
                    return new global::PromptLayer.JsonConverters.ReportColumnSummaryColumnTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage))
                {
                    return new global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage?))
                {
                    return new global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.EditReportColumnRequestColumnType))
                {
                    return new global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.EditReportColumnRequestColumnType?))
                {
                    return new global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.AddReportColumnRequestColumnType))
                {
                    return new global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.AddReportColumnRequestColumnType?))
                {
                    return new global::PromptLayer.JsonConverters.AddReportColumnRequestColumnTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetReportResponseStatus))
                {
                    return new global::PromptLayer.JsonConverters.GetReportResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetReportResponseStatus?))
                {
                    return new global::PromptLayer.JsonConverters.GetReportResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetReportScoreResponseScoreScoreType))
                {
                    return new global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.GetReportScoreResponseScoreScoreType?))
                {
                    return new global::PromptLayer.JsonConverters.GetReportScoreResponseScoreScoreTypeNullableJsonConverter();
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
                    0 => new ReportsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}