
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationPipelineSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_configuration")]
        public global::PromptLayer.ScoreConfiguration? ScoreConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationPipelineSummary" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="tags"></param>
        /// <param name="scoreConfiguration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationPipelineSummary(
            int? id,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            global::PromptLayer.ScoreConfiguration? scoreConfiguration)
        {
            this.Id = id;
            this.Name = name;
            this.Tags = tags;
            this.ScoreConfiguration = scoreConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationPipelineSummary" /> class.
        /// </summary>
        public EvaluationPipelineSummary()
        {
        }

    }
}