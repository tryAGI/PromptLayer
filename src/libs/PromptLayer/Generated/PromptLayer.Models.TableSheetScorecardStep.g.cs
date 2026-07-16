
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScorecardStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primitive_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrimitiveType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_column_ids")]
        public global::System.Collections.Generic.IList<string>? SourceColumnIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thresholds")]
        public global::System.Collections.Generic.Dictionary<string, double>? Thresholds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primitive_config")]
        public object? PrimitiveConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardStep" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="primitiveType"></param>
        /// <param name="id"></param>
        /// <param name="sourceColumnIds"></param>
        /// <param name="weight"></param>
        /// <param name="required"></param>
        /// <param name="thresholds"></param>
        /// <param name="primitiveConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardStep(
            string title,
            string primitiveType,
            global::System.Guid? id,
            global::System.Collections.Generic.IList<string>? sourceColumnIds,
            double? weight,
            bool? required,
            global::System.Collections.Generic.Dictionary<string, double>? thresholds,
            object? primitiveConfig)
        {
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.PrimitiveType = primitiveType ?? throw new global::System.ArgumentNullException(nameof(primitiveType));
            this.SourceColumnIds = sourceColumnIds;
            this.Weight = weight;
            this.Required = required;
            this.Thresholds = thresholds;
            this.PrimitiveConfig = primitiveConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardStep" /> class.
        /// </summary>
        public TableSheetScorecardStep()
        {
        }

    }
}