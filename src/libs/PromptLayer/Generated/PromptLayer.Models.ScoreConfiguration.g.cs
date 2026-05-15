
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Custom scoring configuration. The code receives a data variable containing row dictionaries and must return an object with at least a score key from 0 to 100.<br/>
    /// Example: {"code":"score = sum(1 for row in data if row.get(\u0022Accuracy Check\u0022) is True) / len(data) * 100 if data else 0\nreturn {\u0022score\u0022: score}","code_language":"PYTHON"}
    /// </summary>
    public sealed partial class ScoreConfiguration
    {
        /// <summary>
        /// Python or JavaScript code used to calculate the score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Language used by the scoring code.<br/>
        /// Default Value: PYTHON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.ScoreConfigurationCodeLanguageJsonConverter))]
        public global::PromptLayer.ScoreConfigurationCodeLanguage? CodeLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreConfiguration" /> class.
        /// </summary>
        /// <param name="code">
        /// Python or JavaScript code used to calculate the score.
        /// </param>
        /// <param name="codeLanguage">
        /// Language used by the scoring code.<br/>
        /// Default Value: PYTHON
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreConfiguration(
            string code,
            global::PromptLayer.ScoreConfigurationCodeLanguage? codeLanguage)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CodeLanguage = codeLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreConfiguration" /> class.
        /// </summary>
        public ScoreConfiguration()
        {
        }

    }
}