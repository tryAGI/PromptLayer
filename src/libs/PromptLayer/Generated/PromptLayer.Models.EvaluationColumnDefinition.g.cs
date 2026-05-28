
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Definition for a column in an evaluation pipeline. The configuration schema depends on column_type.<br/>
    /// Example: {"column_type":"LLM_ASSERTION","name":"Accuracy Check","configuration":{"source":"response","prompt":"Is this response accurate?"},"is_part_of_score":true}
    /// </summary>
    public sealed partial class EvaluationColumnDefinition
    {
        /// <summary>
        /// Type of evaluation column to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.EvaluationColumnDefinitionColumnTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.EvaluationColumnDefinitionColumnType ColumnType { get; set; }

        /// <summary>
        /// Display name for the column. Must be unique within the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Column-type-specific configuration. See Node &amp; Column Types for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// 1-based position in the pipeline. Auto-assigned if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// When true, PromptLayer includes this column in built-in scoring by averaging its values.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_part_of_score")]
        public bool? IsPartOfScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationColumnDefinition" /> class.
        /// </summary>
        /// <param name="columnType">
        /// Type of evaluation column to create.
        /// </param>
        /// <param name="name">
        /// Display name for the column. Must be unique within the pipeline.
        /// </param>
        /// <param name="configuration">
        /// Column-type-specific configuration. See Node &amp; Column Types for details.
        /// </param>
        /// <param name="position">
        /// 1-based position in the pipeline. Auto-assigned if omitted.
        /// </param>
        /// <param name="isPartOfScore">
        /// When true, PromptLayer includes this column in built-in scoring by averaging its values.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationColumnDefinition(
            global::PromptLayer.EvaluationColumnDefinitionColumnType columnType,
            string name,
            object configuration,
            int? position,
            bool? isPartOfScore)
        {
            this.ColumnType = columnType;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Position = position;
            this.IsPartOfScore = isPartOfScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationColumnDefinition" /> class.
        /// </summary>
        public EvaluationColumnDefinition()
        {
        }

    }
}