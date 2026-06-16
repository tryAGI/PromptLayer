
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigureTableSheetScoreRequest
    {
        /// <summary>
        /// Scoring mode. Required when score_config is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestScoreTypeJsonConverter))]
        public global::PromptLayer.ConfigureTableSheetScoreRequestScoreType? ScoreType { get; set; }

        /// <summary>
        /// Explicit score configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_config")]
        public object? ScoreConfig { get; set; }

        /// <summary>
        /// Column IDs to score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ColumnIds { get; set; }

        /// <summary>
        /// Column titles to score. Titles must be unique in the sheet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_names")]
        public global::System.Collections.Generic.IList<string>? ColumnNames { get; set; }

        /// <summary>
        /// Custom scoring code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Default Value: PYTHON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestCodeLanguageJsonConverter))]
        public global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage? CodeLanguage { get; set; }

        /// <summary>
        /// Values treated as true for boolean scoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true_values")]
        public global::System.Collections.Generic.IList<string>? TrueValues { get; set; }

        /// <summary>
        /// Values treated as false for boolean scoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false_values")]
        public global::System.Collections.Generic.IList<string>? FalseValues { get; set; }

        /// <summary>
        /// Aggregation mode for assertion-style boolean scoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assertion_aggregation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.ConfigureTableSheetScoreRequestAssertionAggregationJsonConverter))]
        public global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation? AssertionAggregation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTableSheetScoreRequest" /> class.
        /// </summary>
        /// <param name="scoreType">
        /// Scoring mode. Required when score_config is provided.
        /// </param>
        /// <param name="scoreConfig">
        /// Explicit score configuration.
        /// </param>
        /// <param name="columnIds">
        /// Column IDs to score.
        /// </param>
        /// <param name="columnNames">
        /// Column titles to score. Titles must be unique in the sheet.
        /// </param>
        /// <param name="code">
        /// Custom scoring code.
        /// </param>
        /// <param name="codeLanguage">
        /// Default Value: PYTHON
        /// </param>
        /// <param name="trueValues">
        /// Values treated as true for boolean scoring.
        /// </param>
        /// <param name="falseValues">
        /// Values treated as false for boolean scoring.
        /// </param>
        /// <param name="assertionAggregation">
        /// Aggregation mode for assertion-style boolean scoring.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureTableSheetScoreRequest(
            global::PromptLayer.ConfigureTableSheetScoreRequestScoreType? scoreType,
            object? scoreConfig,
            global::System.Collections.Generic.IList<global::System.Guid>? columnIds,
            global::System.Collections.Generic.IList<string>? columnNames,
            string? code,
            global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage? codeLanguage,
            global::System.Collections.Generic.IList<string>? trueValues,
            global::System.Collections.Generic.IList<string>? falseValues,
            global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation? assertionAggregation)
        {
            this.ScoreType = scoreType;
            this.ScoreConfig = scoreConfig;
            this.ColumnIds = columnIds;
            this.ColumnNames = columnNames;
            this.Code = code;
            this.CodeLanguage = codeLanguage;
            this.TrueValues = trueValues;
            this.FalseValues = falseValues;
            this.AssertionAggregation = assertionAggregation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTableSheetScoreRequest" /> class.
        /// </summary>
        public ConfigureTableSheetScoreRequest()
        {
        }

    }
}