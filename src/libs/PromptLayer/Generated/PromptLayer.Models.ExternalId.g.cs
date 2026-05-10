
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Customer-defined mapping between a PromptLayer entity and an external system identifier.
    /// </summary>
    public sealed partial class ExternalId
    {
        /// <summary>
        /// The external system or namespace that owns the ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// The identifier for this entity in the external system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalId" /> class.
        /// </summary>
        /// <param name="source">
        /// The external system or namespace that owns the ID.
        /// </param>
        /// <param name="externalId1">
        /// The identifier for this entity in the external system.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalId(
            string source,
            string externalId1)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.ExternalId1 = externalId1 ?? throw new global::System.ArgumentNullException(nameof(externalId1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalId" /> class.
        /// </summary>
        public ExternalId()
        {
        }

    }
}