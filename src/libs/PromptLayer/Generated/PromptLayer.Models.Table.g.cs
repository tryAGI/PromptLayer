
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// A Table — a versioned, multi-sheet table that can run LLM columns to generate or evaluate data at scale.
    /// </summary>
    public sealed partial class Table
    {
        /// <summary>
        /// Unique table identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Workspace that owns this resource; determined by the authenticated request scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Number of active sheets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_count")]
        public int? SheetCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique table identifier.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace that owns this resource; determined by the authenticated request scope.
        /// </param>
        /// <param name="title"></param>
        /// <param name="folderId"></param>
        /// <param name="sheetCount">
        /// Number of active sheets.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Table(
            global::System.Guid? id,
            int? workspaceId,
            string? title,
            int? folderId,
            int? sheetCount,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.Title = title;
            this.FolderId = folderId;
            this.SheetCount = sheetCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        public Table()
        {
        }

    }
}