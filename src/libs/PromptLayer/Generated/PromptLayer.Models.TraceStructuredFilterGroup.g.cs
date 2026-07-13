
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Nested filter tree. AND/OR are cross-span; SPAN_AND/SPAN_OR require one and the same span to satisfy every/any branch (span-level fields only).
    /// </summary>
    public sealed partial class TraceStructuredFilterGroup
    {
        /// <summary>
        /// Default Value: AND
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceStructuredFilterGroupLogicJsonConverter))]
        public global::PromptLayer.TraceStructuredFilterGroupLogic? Logic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>> Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceStructuredFilterGroup" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="logic">
        /// Default Value: AND
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceStructuredFilterGroup(
            global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>> filters,
            global::PromptLayer.TraceStructuredFilterGroupLogic? logic)
        {
            this.Logic = logic;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceStructuredFilterGroup" /> class.
        /// </summary>
        public TraceStructuredFilterGroup()
        {
        }

    }
}