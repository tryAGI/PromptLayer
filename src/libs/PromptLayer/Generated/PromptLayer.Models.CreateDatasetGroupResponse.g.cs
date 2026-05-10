
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.DatasetGroup DatasetGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.Dataset Dataset { get; set; }

        /// <summary>
        /// External ID mappings for the dataset group.
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
        /// <param name="message"></param>
        /// <param name="datasetGroup"></param>
        /// <param name="dataset"></param>
        /// <param name="externalIds">
        /// External ID mappings for the dataset group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetGroupResponse(
            bool success,
            string message,
            global::PromptLayer.DatasetGroup datasetGroup,
            global::PromptLayer.Dataset dataset,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId> externalIds)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DatasetGroup = datasetGroup ?? throw new global::System.ArgumentNullException(nameof(datasetGroup));
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
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