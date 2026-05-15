
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetGroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.DatasetGroup, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.AnyOf<global::PromptLayer.DatasetGroup, object> DatasetGroup { get; set; }

        /// <summary>
        /// Initial draft dataset created with version_number = -1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<global::PromptLayer.Dataset, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.AnyOf<global::PromptLayer.Dataset, object> Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.ExternalId> ExternalIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetGroupResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="datasetGroup"></param>
        /// <param name="dataset">
        /// Initial draft dataset created with version_number = -1.
        /// </param>
        /// <param name="externalIds"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetGroupResponse(
            bool success,
            global::PromptLayer.AnyOf<global::PromptLayer.DatasetGroup, object> datasetGroup,
            global::PromptLayer.AnyOf<global::PromptLayer.Dataset, object> dataset,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId> externalIds,
            string? message)
        {
            this.Success = success;
            this.Message = message;
            this.DatasetGroup = datasetGroup;
            this.Dataset = dataset;
            this.ExternalIds = externalIds ?? throw new global::System.ArgumentNullException(nameof(externalIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetGroupResponse" /> class.
        /// </summary>
        public CreateDatasetGroupResponse()
        {
        }

    }
}