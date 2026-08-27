
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteTableSheetColumnResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Number of stale cells on the sheet after downstream dependency propagation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale_count")]
        public int? StaleCount { get; set; }

        /// <summary>
        /// Current sheet version_count after the column is deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableSheetColumnResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="staleCount">
        /// Number of stale cells on the sheet after downstream dependency propagation.
        /// </param>
        /// <param name="version">
        /// Current sheet version_count after the column is deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTableSheetColumnResponse(
            bool? success,
            string? message,
            int? staleCount,
            int? version)
        {
            this.Success = success;
            this.Message = message;
            this.StaleCount = staleCount;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableSheetColumnResponse" /> class.
        /// </summary>
        public DeleteTableSheetColumnResponse()
        {
        }

    }
}