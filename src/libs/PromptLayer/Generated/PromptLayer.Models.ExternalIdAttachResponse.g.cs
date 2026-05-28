
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalIdAttachResponse
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Customer-defined mapping between a PromptLayer entity and an external system identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.ExternalId ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalIdAttachResponse" /> class.
        /// </summary>
        /// <param name="externalId">
        /// Customer-defined mapping between a PromptLayer entity and an external system identifier.
        /// </param>
        /// <param name="success">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalIdAttachResponse(
            global::PromptLayer.ExternalId externalId,
            bool success)
        {
            this.Success = success;
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalIdAttachResponse" /> class.
        /// </summary>
        public ExternalIdAttachResponse()
        {
        }
    }
}