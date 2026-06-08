
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTableSheetColumnRequestDependencie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ColumnId { get; set; }

        /// <summary>
        /// Default Value: value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_type")]
        public string? ReferenceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_key")]
        public string? ConfigKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_meta")]
        public object? ConfigMeta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetColumnRequestDependencie" /> class.
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="referenceType">
        /// Default Value: value
        /// </param>
        /// <param name="configKey"></param>
        /// <param name="configMeta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTableSheetColumnRequestDependencie(
            global::System.Guid columnId,
            string? referenceType,
            string? configKey,
            object? configMeta)
        {
            this.ColumnId = columnId;
            this.ReferenceType = referenceType;
            this.ConfigKey = configKey;
            this.ConfigMeta = configMeta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetColumnRequestDependencie" /> class.
        /// </summary>
        public UpdateTableSheetColumnRequestDependencie()
        {
        }

    }
}