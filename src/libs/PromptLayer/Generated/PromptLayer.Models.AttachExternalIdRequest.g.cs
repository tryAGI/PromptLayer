
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// External ID mapping to attach to an entity.
    /// </summary>
    public sealed partial class AttachExternalIdRequest
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
        public required string ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachExternalIdRequest" /> class.
        /// </summary>
        /// <param name="source">
        /// The external system or namespace that owns the ID.
        /// </param>
        /// <param name="externalId">
        /// The identifier for this entity in the external system.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachExternalIdRequest(
            string source,
            string externalId)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachExternalIdRequest" /> class.
        /// </summary>
        public AttachExternalIdRequest()
        {
        }
    }
}