
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// A group of filters combined with AND or OR logic. Can be nested recursively.
    /// </summary>
    public sealed partial class StructuredFilterGroup
    {
        /// <summary>
        /// How to combine the filters in this group.<br/>
        /// Default Value: AND
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.StructuredFilterGroupLogicJsonConverter))]
        public global::PromptLayer.StructuredFilterGroupLogic? Logic { get; set; }

        /// <summary>
        /// List of filters or nested filter groups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>> Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredFilterGroup" /> class.
        /// </summary>
        /// <param name="logic">
        /// How to combine the filters in this group.<br/>
        /// Default Value: AND
        /// </param>
        /// <param name="filters">
        /// List of filters or nested filter groups.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredFilterGroup(
            global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>> filters,
            global::PromptLayer.StructuredFilterGroupLogic? logic)
        {
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Logic = logic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredFilterGroup" /> class.
        /// </summary>
        public StructuredFilterGroup()
        {
        }
    }
}