
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetVersion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SheetId { get; set; }

        /// <summary>
        /// Sequential saved version number for this sheet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deltas")]
        public global::System.Collections.Generic.IList<object>? Deltas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot")]
        public object? Snapshot { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public object? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_configuration")]
        public object? ScoreConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetVersion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sheetId"></param>
        /// <param name="versionNumber">
        /// Sequential saved version number for this sheet.
        /// </param>
        /// <param name="name"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="metadata"></param>
        /// <param name="deltas"></param>
        /// <param name="snapshot"></param>
        /// <param name="score"></param>
        /// <param name="scoreConfiguration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetVersion(
            global::System.Guid id,
            global::System.Guid sheetId,
            int versionNumber,
            string? name,
            string? createdBy,
            global::System.DateTime? createdAt,
            object? metadata,
            global::System.Collections.Generic.IList<object>? deltas,
            object? snapshot,
            object? score,
            object? scoreConfiguration)
        {
            this.Id = id;
            this.SheetId = sheetId;
            this.VersionNumber = versionNumber;
            this.Name = name;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.Metadata = metadata;
            this.Deltas = deltas;
            this.Snapshot = snapshot;
            this.Score = score;
            this.ScoreConfiguration = scoreConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetVersion" /> class.
        /// </summary>
        public TableSheetVersion()
        {
        }

    }
}