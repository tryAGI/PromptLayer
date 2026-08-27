
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateToolEnvVarRequest
    {
        /// <summary>
        /// Environment variable name. Must start with a letter or underscore and contain only letters, digits, and underscores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Value to store. May be empty to create a placeholder that the user will fill in later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolEnvVarRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// Environment variable name. Must start with a letter or underscore and contain only letters, digits, and underscores.
        /// </param>
        /// <param name="value">
        /// Value to store. May be empty to create a placeholder that the user will fill in later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolEnvVarRequest(
            string key,
            string? value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolEnvVarRequest" /> class.
        /// </summary>
        public CreateToolEnvVarRequest()
        {
        }

    }
}