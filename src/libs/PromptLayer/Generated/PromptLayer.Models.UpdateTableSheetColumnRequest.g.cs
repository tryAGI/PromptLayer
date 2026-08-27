
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateTableSheetColumnRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetColumnRequest" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="config"></param>
        /// <param name="dependencies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTableSheetColumnRequest(
            string? title,
            object? config,
            global::System.Collections.Generic.IList<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>? dependencies)
        {
            this.Title = title;
            this.Config = config;
            this.Dependencies = dependencies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableSheetColumnRequest" /> class.
        /// </summary>
        public UpdateTableSheetColumnRequest()
        {
        }

    }
}