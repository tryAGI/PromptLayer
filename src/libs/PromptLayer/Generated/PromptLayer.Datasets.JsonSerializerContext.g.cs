
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DatasetGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterField), TypeInfoPropertyName = "StructuredFilterField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterOperator), TypeInfoPropertyName = "StructuredFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, double?, bool?, byte[], object>), TypeInfoPropertyName = "OneOfStringDoubleBooleanByteArrayObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroupLogic), TypeInfoPropertyName = "StructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>), TypeInfoPropertyName = "OneOfStructuredFilterStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalIdErrorResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DatasetRowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.DatasetRowCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.DatasetRowCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDraftDatasetVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DraftDatasetVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddRequestLogToDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SaveDraftDatasetVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTraceToDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTraceToDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTraceToDatasetResponseMode), TypeInfoPropertyName = "AddTraceToDatasetResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsStatus), TypeInfoPropertyName = "ListDatasetsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsSortBy), TypeInfoPropertyName = "ListDatasetsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsSortOrder), TypeInfoPropertyName = "ListDatasetsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>), TypeInfoPropertyName = "OneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterField?), TypeInfoPropertyName = "NullableStructuredFilterField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterOperator?), TypeInfoPropertyName = "NullableStructuredFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, double?, bool?, byte[], object>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanByteArrayObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StructuredFilterGroupLogic?), TypeInfoPropertyName = "NullableStructuredFilterGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>?), TypeInfoPropertyName = "NullableOneOfStructuredFilterStructuredFilterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<global::PromptLayer.DatasetGroup, object>?), TypeInfoPropertyName = "NullableAnyOfDatasetGroupObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<global::PromptLayer.Dataset, object>?), TypeInfoPropertyName = "NullableAnyOfDatasetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy?), TypeInfoPropertyName = "NullableCreateDatasetVersionFromFilterParamsRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder?), TypeInfoPropertyName = "NullableCreateDatasetVersionFromFilterParamsRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DatasetRowCellType?), TypeInfoPropertyName = "NullableDatasetRowCellType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTraceToDatasetResponseMode?), TypeInfoPropertyName = "NullableAddTraceToDatasetResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsStatus?), TypeInfoPropertyName = "NullableListDatasetsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsSortBy?), TypeInfoPropertyName = "NullableListDatasetsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListDatasetsSortOrder?), TypeInfoPropertyName = "NullableListDatasetsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>?), TypeInfoPropertyName = "NullableOneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ExternalId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.DatasetRowCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.DatasetRowCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Dataset>))]
    internal sealed partial class DatasetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatasetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatasetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.DatasetGroup, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.Dataset, object>());
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
                    typeToConvert == typeof(global::PromptLayer.StructuredFilterField)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterField?)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterOperator)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterOperator?)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterGroupLogic)

                    || typeToConvert == typeof(global::PromptLayer.StructuredFilterGroupLogic?)

                    || typeToConvert == typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy)

                    || typeToConvert == typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy?)

                    || typeToConvert == typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder)

                    || typeToConvert == typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder?)

                    || typeToConvert == typeof(global::PromptLayer.DatasetRowCellType)

                    || typeToConvert == typeof(global::PromptLayer.DatasetRowCellType?)

                    || typeToConvert == typeof(global::PromptLayer.AddTraceToDatasetResponseMode)

                    || typeToConvert == typeof(global::PromptLayer.AddTraceToDatasetResponseMode?)

                    || typeToConvert == typeof(global::PromptLayer.ListDatasetsStatus)

                    || typeToConvert == typeof(global::PromptLayer.ListDatasetsStatus?)

                    || typeToConvert == typeof(global::PromptLayer.ListDatasetsSortBy)

                    || typeToConvert == typeof(global::PromptLayer.ListDatasetsSortBy?)

                    || typeToConvert == typeof(global::PromptLayer.ListDatasetsSortOrder)

                    || typeToConvert == typeof(global::PromptLayer.ListDatasetsSortOrder?);
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

                if (typeToConvert == typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy))
                {
                    return new global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy?))
                {
                    return new global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder))
                {
                    return new global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder?))
                {
                    return new global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DatasetRowCellType))
                {
                    return new global::PromptLayer.JsonConverters.DatasetRowCellTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DatasetRowCellType?))
                {
                    return new global::PromptLayer.JsonConverters.DatasetRowCellTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.AddTraceToDatasetResponseMode))
                {
                    return new global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.AddTraceToDatasetResponseMode?))
                {
                    return new global::PromptLayer.JsonConverters.AddTraceToDatasetResponseModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListDatasetsStatus))
                {
                    return new global::PromptLayer.JsonConverters.ListDatasetsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListDatasetsStatus?))
                {
                    return new global::PromptLayer.JsonConverters.ListDatasetsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListDatasetsSortBy))
                {
                    return new global::PromptLayer.JsonConverters.ListDatasetsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListDatasetsSortBy?))
                {
                    return new global::PromptLayer.JsonConverters.ListDatasetsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListDatasetsSortOrder))
                {
                    return new global::PromptLayer.JsonConverters.ListDatasetsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListDatasetsSortOrder?))
                {
                    return new global::PromptLayer.JsonConverters.ListDatasetsSortOrderNullableJsonConverter();
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
                    0 => new DatasetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}