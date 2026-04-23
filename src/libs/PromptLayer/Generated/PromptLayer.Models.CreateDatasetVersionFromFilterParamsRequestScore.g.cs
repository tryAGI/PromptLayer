
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsRequestScore
    {
        /// <summary>
        /// Score name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Comparison operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestScoreOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScoreOperator Operator { get; set; }

        /// <summary>
        /// Score value to compare against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestScore" /> class.
        /// </summary>
        /// <param name="name">
        /// Score name.
        /// </param>
        /// <param name="operator">
        /// Comparison operator.
        /// </param>
        /// <param name="value">
        /// Score value to compare against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFilterParamsRequestScore(
            string name,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScoreOperator @operator,
            int value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestScore" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequestScore()
        {
        }
    }
}