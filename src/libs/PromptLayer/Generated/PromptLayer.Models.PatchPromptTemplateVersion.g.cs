
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Request body for partially updating a prompt template by creating a new version from the latest, a specific version, or a release label.
    /// </summary>
    public sealed partial class PatchPromptTemplateVersion
    {
        /// <summary>
        /// The base version number to patch from. Mutually exclusive with `label`. If neither is provided, the latest version is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// The release label identifying the base version to patch from (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Patch for chat template messages. Object keys are message indexes for index-based patching; arrays replace all messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Messages { get; set; }

        /// <summary>
        /// Patch for tools. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Tools { get; set; }

        /// <summary>
        /// Patch for functions. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Functions { get; set; }

        /// <summary>
        /// Replace the function_call setting. Set to null to remove. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::PromptLayer.AnyOf<string, object, object>? FunctionCall { get; set; }

        /// <summary>
        /// Replace the tool_choice setting. Set to null to remove. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::PromptLayer.AnyOf<string, object, object>? ToolChoice { get; set; }

        /// <summary>
        /// Patch for completion template content. Object for index-based patching, array for full replacement. Completion templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Content { get; set; }

        /// <summary>
        /// Parameters to shallow-merge into existing model parameters. Existing keys not provided are preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Convenience field to set response_format in model parameters. Cannot be used simultaneously with response_format inside model_parameters. Set to null to remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public object? ResponseFormat { get; set; }

        /// <summary>
        /// A message describing the changes in this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Release labels to create or move to the newly created version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPromptTemplateVersion" /> class.
        /// </summary>
        /// <param name="version">
        /// The base version number to patch from. Mutually exclusive with `label`. If neither is provided, the latest version is used.
        /// </param>
        /// <param name="label">
        /// The release label identifying the base version to patch from (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="messages">
        /// Patch for chat template messages. Object keys are message indexes for index-based patching; arrays replace all messages.
        /// </param>
        /// <param name="tools">
        /// Patch for tools. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </param>
        /// <param name="functions">
        /// Patch for functions. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </param>
        /// <param name="functionCall">
        /// Replace the function_call setting. Set to null to remove. Chat templates only.
        /// </param>
        /// <param name="toolChoice">
        /// Replace the tool_choice setting. Set to null to remove. Chat templates only.
        /// </param>
        /// <param name="content">
        /// Patch for completion template content. Object for index-based patching, array for full replacement. Completion templates only.
        /// </param>
        /// <param name="modelParameters">
        /// Parameters to shallow-merge into existing model parameters. Existing keys not provided are preserved.
        /// </param>
        /// <param name="responseFormat">
        /// Convenience field to set response_format in model parameters. Cannot be used simultaneously with response_format inside model_parameters. Set to null to remove.
        /// </param>
        /// <param name="commitMessage">
        /// A message describing the changes in this version.
        /// </param>
        /// <param name="releaseLabels">
        /// Release labels to create or move to the newly created version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchPromptTemplateVersion(
            int? version,
            string? label,
            global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? messages,
            global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? tools,
            global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? functions,
            global::PromptLayer.AnyOf<string, object, object>? functionCall,
            global::PromptLayer.AnyOf<string, object, object>? toolChoice,
            global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? content,
            object? modelParameters,
            object? responseFormat,
            string? commitMessage,
            global::System.Collections.Generic.IList<string>? releaseLabels)
        {
            this.Version = version;
            this.Label = label;
            this.Messages = messages;
            this.Tools = tools;
            this.Functions = functions;
            this.FunctionCall = functionCall;
            this.ToolChoice = toolChoice;
            this.Content = content;
            this.ModelParameters = modelParameters;
            this.ResponseFormat = responseFormat;
            this.CommitMessage = commitMessage;
            this.ReleaseLabels = releaseLabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPromptTemplateVersion" /> class.
        /// </summary>
        public PatchPromptTemplateVersion()
        {
        }

    }
}