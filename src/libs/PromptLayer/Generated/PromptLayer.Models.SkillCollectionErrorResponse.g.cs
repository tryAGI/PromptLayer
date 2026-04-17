
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Error response format returned by the public skill collection endpoints.
    /// </summary>
    public sealed partial class SkillCollectionErrorResponse
    {
        /// <summary>
        /// Indicates that the request failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Error message explaining why the request failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillCollectionErrorResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates that the request failed.
        /// </param>
        /// <param name="message">
        /// Error message explaining why the request failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillCollectionErrorResponse(
            bool success,
            string message)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillCollectionErrorResponse" /> class.
        /// </summary>
        public SkillCollectionErrorResponse()
        {
        }
    }
}