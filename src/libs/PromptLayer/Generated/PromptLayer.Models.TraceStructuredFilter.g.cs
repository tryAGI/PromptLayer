
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Trace structured filter. field accepts trace-level (trace_*) and span-level (span_*) names.
    /// </summary>
    public sealed partial class TraceStructuredFilter
    {
        /// <summary>
        /// Trace or span field, e.g. trace_name, trace_start, span_tool_name, span_duration_ms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Filter operator, e.g. is, in, contains, gt, between, is_not_empty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Filter value (type depends on operator)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Key name for nested span field operators (span_attributes, span_resource, span_input_variables)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested_key")]
        public string? NestedKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceStructuredFilter" /> class.
        /// </summary>
        /// <param name="field">
        /// Trace or span field, e.g. trace_name, trace_start, span_tool_name, span_duration_ms
        /// </param>
        /// <param name="operator">
        /// Filter operator, e.g. is, in, contains, gt, between, is_not_empty
        /// </param>
        /// <param name="value">
        /// Filter value (type depends on operator)
        /// </param>
        /// <param name="nestedKey">
        /// Key name for nested span field operators (span_attributes, span_resource, span_input_variables)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceStructuredFilter(
            string field,
            string @operator,
            object? value,
            string? nestedKey)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Value = value;
            this.NestedKey = nestedKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceStructuredFilter" /> class.
        /// </summary>
        public TraceStructuredFilter()
        {
        }

    }
}