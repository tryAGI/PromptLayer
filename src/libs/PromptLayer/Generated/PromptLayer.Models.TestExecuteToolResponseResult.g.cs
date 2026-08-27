
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestExecuteToolResponseResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TestExecuteToolResponseResultStatusJsonConverter))]
        public global::PromptLayer.TestExecuteToolResponseResultStatus? Status { get; set; }

        /// <summary>
        /// The tool body's return value (any JSON-serializable type). Present on status="success".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        public string? Stdout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        public string? Stderr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Present on status="error". Includes `type` and `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestExecuteToolResponseResult" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result">
        /// The tool body's return value (any JSON-serializable type). Present on status="success".
        /// </param>
        /// <param name="stdout"></param>
        /// <param name="stderr"></param>
        /// <param name="durationMs"></param>
        /// <param name="error">
        /// Present on status="error". Includes `type` and `message`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestExecuteToolResponseResult(
            global::PromptLayer.TestExecuteToolResponseResultStatus? status,
            object? result,
            string? stdout,
            string? stderr,
            int? durationMs,
            object? error)
        {
            this.Status = status;
            this.Result = result;
            this.Stdout = stdout;
            this.Stderr = stderr;
            this.DurationMs = durationMs;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestExecuteToolResponseResult" /> class.
        /// </summary>
        public TestExecuteToolResponseResult()
        {
        }

    }
}