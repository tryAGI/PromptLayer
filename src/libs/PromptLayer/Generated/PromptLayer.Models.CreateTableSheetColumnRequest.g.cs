
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetColumnRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Smart Table column type. Use uppercase backend enum values. Input: TEXT. Reference (Tables only, not in legacy evaluation/workflow enums): COMPOSITION. Computed: all other listed values. Create requests also accept lowercase aliases (text, prompt_template, llm, code, score, comparison, composition), which are normalized to uppercase. Legacy DATASET columns are not creatable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableColumnTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableColumnType Type { get; set; }

        /// <summary>
        /// Type-specific column configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Column dependency edges for non-text columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetColumnRequestDependencie>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetColumnRequest" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="type">
        /// Smart Table column type. Use uppercase backend enum values. Input: TEXT. Reference (Tables only, not in legacy evaluation/workflow enums): COMPOSITION. Computed: all other listed values. Create requests also accept lowercase aliases (text, prompt_template, llm, code, score, comparison, composition), which are normalized to uppercase. Legacy DATASET columns are not creatable.
        /// </param>
        /// <param name="config">
        /// Type-specific column configuration.
        /// </param>
        /// <param name="dependencies">
        /// Column dependency edges for non-text columns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetColumnRequest(
            string title,
            global::PromptLayer.TableColumnType type,
            object? config,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetColumnRequestDependencie>? dependencies)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
            this.Config = config;
            this.Dependencies = dependencies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetColumnRequest" /> class.
        /// </summary>
        public CreateTableSheetColumnRequest()
        {
        }

    }
}