
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Structured filter group, identical in shape to the one accepted by `POST /api/public/v2/requests/search`. The full payload is persisted to the dataset so it can be replayed on refresh.
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsRequestFilterGroup
    {
        /// <summary>
        /// How to combine the filters in this group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestFilterGroupLogicJsonConverter))]
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic? Logic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestFilterGroupFilter>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestFilterGroup" /> class.
        /// </summary>
        /// <param name="logic">
        /// How to combine the filters in this group.
        /// </param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFilterParamsRequestFilterGroup(
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestFilterGroupLogic? logic,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestFilterGroupFilter>? filters)
        {
            this.Logic = logic;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestFilterGroup" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequestFilterGroup()
        {
        }

    }
}