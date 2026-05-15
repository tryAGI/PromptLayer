
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateReportScoreCardRequest
    {
        /// <summary>
        /// Column names to include in the score calculation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ColumnNames { get; set; }

        /// <summary>
        /// Optional custom Python or JavaScript scoring code. The code receives data and must return an object with a score key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Language used by the custom scoring code.<br/>
        /// Default Value: PYTHON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.UpdateReportScoreCardRequestCodeLanguageJsonConverter))]
        public global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage? CodeLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReportScoreCardRequest" /> class.
        /// </summary>
        /// <param name="columnNames">
        /// Column names to include in the score calculation.
        /// </param>
        /// <param name="code">
        /// Optional custom Python or JavaScript scoring code. The code receives data and must return an object with a score key.
        /// </param>
        /// <param name="codeLanguage">
        /// Language used by the custom scoring code.<br/>
        /// Default Value: PYTHON
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateReportScoreCardRequest(
            global::System.Collections.Generic.IList<string> columnNames,
            string? code,
            global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage? codeLanguage)
        {
            this.ColumnNames = columnNames ?? throw new global::System.ArgumentNullException(nameof(columnNames));
            this.Code = code;
            this.CodeLanguage = codeLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReportScoreCardRequest" /> class.
        /// </summary>
        public UpdateReportScoreCardRequest()
        {
        }

    }
}