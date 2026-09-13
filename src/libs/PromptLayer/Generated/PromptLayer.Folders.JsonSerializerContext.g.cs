
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_a2e389e01f671d8d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>?), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_47a8c666c2b64908")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem_13c51ceff6c2844e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ExternalIdErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder), TypeInfoPropertyName = "ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>), TypeInfoPropertyName = "OneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<global::PromptLayer.FolderExistsError, string>), TypeInfoPropertyName = "AnyOfFolderExistsErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.EntityType?), TypeInfoPropertyName = "NullableEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>?), TypeInfoPropertyName = "NullableOneOfPromptEntityMetadataWorkflowEntityMetadataDatasetEntityMetadataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptEntityMetadataType?), TypeInfoPropertyName = "NullablePromptEntityMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?), TypeInfoPropertyName = "NullableListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem?), TypeInfoPropertyName = "NullableListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy?), TypeInfoPropertyName = "NullableListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder?), TypeInfoPropertyName = "NullableListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>?), TypeInfoPropertyName = "NullableOneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<global::PromptLayer.FolderExistsError, string>?), TypeInfoPropertyName = "NullableAnyOfFolderExistsErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ExternalId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.FolderEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<string, global::System.Collections.Generic.List<string>>))]
    internal sealed partial class FoldersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FoldersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FoldersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FoldersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<string, double?, bool?, byte[], object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
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
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
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
                    typeToConvert == typeof(global::PromptLayer.EntityType)

                    || typeToConvert == typeof(global::PromptLayer.EntityType?)

                    || typeToConvert == typeof(global::PromptLayer.PromptEntityMetadataType)

                    || typeToConvert == typeof(global::PromptLayer.PromptEntityMetadataType?)

                    || typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2)

                    || typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?)

                    || typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem)

                    || typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem?)

                    || typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy)

                    || typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy?)

                    || typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder)

                    || typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::PromptLayer.EntityType))
                {
                    return new global::PromptLayer.JsonConverters.EntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.EntityType?))
                {
                    return new global::PromptLayer.JsonConverters.EntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.PromptEntityMetadataType))
                {
                    return new global::PromptLayer.JsonConverters.PromptEntityMetadataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.PromptEntityMetadataType?))
                {
                    return new global::PromptLayer.JsonConverters.PromptEntityMetadataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2))
                {
                    return new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2JsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?))
                {
                    return new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem))
                {
                    return new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem?))
                {
                    return new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy))
                {
                    return new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy?))
                {
                    return new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder))
                {
                    return new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder?))
                {
                    return new global::PromptLayer.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrderNullableJsonConverter();
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
                    0 => new FoldersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}