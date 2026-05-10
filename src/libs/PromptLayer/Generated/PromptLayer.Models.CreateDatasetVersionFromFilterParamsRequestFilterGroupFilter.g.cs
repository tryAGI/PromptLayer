
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsRequestFilterGroupFilter
    {
        /// <summary>
        /// Request-log field to filter on (e.g. `request_start_time`, `tags`, `metadata`, `cost`, `latency_ms`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Comparison operator (e.g. `eq`, `in`, `between`, `gte`, `lte`, `contains`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Operator-specific value. Type depends on the operator (single value, list, or `[from, to]` range).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// For nested fields like `metadata`, the key inside the nested object to filter against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested_key")]
        public string? NestedKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestFilterGroupFilter" /> class.
        /// </summary>
        /// <param name="field">
        /// Request-log field to filter on (e.g. `request_start_time`, `tags`, `metadata`, `cost`, `latency_ms`).
        /// </param>
        /// <param name="operator">
        /// Comparison operator (e.g. `eq`, `in`, `between`, `gte`, `lte`, `contains`).
        /// </param>
        /// <param name="value">
        /// Operator-specific value. Type depends on the operator (single value, list, or `[from, to]` range).
        /// </param>
        /// <param name="nestedKey">
        /// For nested fields like `metadata`, the key inside the nested object to filter against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFilterParamsRequestFilterGroupFilter(
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
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestFilterGroupFilter" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequestFilterGroupFilter()
        {
        }

    }
}