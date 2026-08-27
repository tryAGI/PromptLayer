
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateSkillCollectionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// A skill collection container in the public API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.SkillCollection SkillCollection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSkillCollectionResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="skillCollection">
        /// A skill collection container in the public API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSkillCollectionResponse(
            bool success,
            global::PromptLayer.SkillCollection skillCollection)
        {
            this.Success = success;
            this.SkillCollection = skillCollection ?? throw new global::System.ArgumentNullException(nameof(skillCollection));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSkillCollectionResponse" /> class.
        /// </summary>
        public UpdateSkillCollectionResponse()
        {
        }

    }
}