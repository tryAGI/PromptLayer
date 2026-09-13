
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Table))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Sheet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableColumnType), TypeInfoPropertyName = "TableColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Column))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>), TypeInfoPropertyName = "OneOfCreateTableSheetRequestSourceFileSourceCreateTableSheetRequestSourceRequestLogsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSourceType), TypeInfoPropertyName = "CreateTableSheetRequestSourceFileSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType), TypeInfoPropertyName = "CreateTableSheetRequestSourceRequestLogsSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetColumnRequestDependencie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetColumnRequestDependencie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetColumnRequestDependencie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AddTableSheetRowsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetCellRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetCellRecalculationsBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTablesOrder), TypeInfoPropertyName = "ListTablesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetsOrder), TypeInfoPropertyName = "ListTableSheetsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetRowsOrder), TypeInfoPropertyName = "ListTableSheetRowsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>), TypeInfoPropertyName = "OneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteTableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Sheet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetOperationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.GetTableSheetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteTableSheetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetColumnsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetColumnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UpdateTableSheetColumnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeleteTableSheetColumnResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableColumnType?), TypeInfoPropertyName = "NullableTableColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CellStatus?), TypeInfoPropertyName = "NullableCellStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperationSource?), TypeInfoPropertyName = "NullableTableImportOperationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TableImportOperationStatus?), TypeInfoPropertyName = "NullableTableImportOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey?), TypeInfoPropertyName = "NullableExecutionMetadataMetricAggregateMetricKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>?), TypeInfoPropertyName = "NullableOneOfCreateTableSheetRequestSourceFileSourceCreateTableSheetRequestSourceRequestLogsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSourceType?), TypeInfoPropertyName = "NullableCreateTableSheetRequestSourceFileSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType?), TypeInfoPropertyName = "NullableCreateTableSheetRequestSourceRequestLogsSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTablesOrder?), TypeInfoPropertyName = "NullableListTablesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetsOrder?), TypeInfoPropertyName = "NullableListTableSheetsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListTableSheetRowsOrder?), TypeInfoPropertyName = "NullableListTableSheetRowsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>?), TypeInfoPropertyName = "NullableOneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.CreateTableSheetColumnRequestDependencie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Sheet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListTableSheetRowsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AddTableSheetRowsResponseRow>))]
    internal sealed partial class SmartTablesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SmartTablesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SmartTablesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SmartTablesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>());
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
                    typeToConvert == typeof(global::PromptLayer.TableColumnType)

                    || typeToConvert == typeof(global::PromptLayer.TableColumnType?)

                    || typeToConvert == typeof(global::PromptLayer.CellStatus)

                    || typeToConvert == typeof(global::PromptLayer.CellStatus?)

                    || typeToConvert == typeof(global::PromptLayer.TableImportOperationSource)

                    || typeToConvert == typeof(global::PromptLayer.TableImportOperationSource?)

                    || typeToConvert == typeof(global::PromptLayer.TableImportOperationStatus)

                    || typeToConvert == typeof(global::PromptLayer.TableImportOperationStatus?)

                    || typeToConvert == typeof(global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey)

                    || typeToConvert == typeof(global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey?)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSourceType)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSourceType?)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType)

                    || typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType?)

                    || typeToConvert == typeof(global::PromptLayer.ListTablesOrder)

                    || typeToConvert == typeof(global::PromptLayer.ListTablesOrder?)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetsOrder)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetsOrder?)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetRowsOrder)

                    || typeToConvert == typeof(global::PromptLayer.ListTableSheetRowsOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::PromptLayer.TableColumnType))
                {
                    return new global::PromptLayer.JsonConverters.TableColumnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TableColumnType?))
                {
                    return new global::PromptLayer.JsonConverters.TableColumnTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CellStatus))
                {
                    return new global::PromptLayer.JsonConverters.CellStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CellStatus?))
                {
                    return new global::PromptLayer.JsonConverters.CellStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey))
                {
                    return new global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey?))
                {
                    return new global::PromptLayer.JsonConverters.ExecutionMetadataMetricAggregateMetricKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSourceType))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestSourceFileSourceType?))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType?))
                {
                    return new global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceRequestLogsSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTablesOrder))
                {
                    return new global::PromptLayer.JsonConverters.ListTablesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTablesOrder?))
                {
                    return new global::PromptLayer.JsonConverters.ListTablesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetsOrder))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetsOrder?))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetRowsOrder))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetRowsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListTableSheetRowsOrder?))
                {
                    return new global::PromptLayer.JsonConverters.ListTableSheetRowsOrderNullableJsonConverter();
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
                    0 => new SmartTablesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}