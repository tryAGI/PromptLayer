
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableRequest
    {
        /// <summary>
        /// Table title. Defaults to a unique 'Untitled Table' name if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Folder to place the table in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// When true (default), creates Sheet 1 with a Column A text column and one empty row. When false, creates an empty table with no sheets.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_default_sheet")]
        public bool? CreateDefaultSheet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// Table title. Defaults to a unique 'Untitled Table' name if omitted.
        /// </param>
        /// <param name="folderId">
        /// Folder to place the table in.
        /// </param>
        /// <param name="createDefaultSheet">
        /// When true (default), creates Sheet 1 with a Column A text column and one empty row. When false, creates an empty table with no sheets.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableRequest(
            string? title,
            int? folderId,
            bool? createDefaultSheet)
        {
            this.Title = title;
            this.FolderId = folderId;
            this.CreateDefaultSheet = createDefaultSheet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableRequest" /> class.
        /// </summary>
        public CreateTableRequest()
        {
        }

    }
}