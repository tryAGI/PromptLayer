#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentItem4 : global::System.IEquatable<ContentItem4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeveloperMessageContentItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.TextContent? Text { get; init; }
#else
        public global::PromptLayer.TextContent? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.TextContent? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TextContent PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ThinkingContent? Thinking { get; init; }
#else
        public global::PromptLayer.ThinkingContent? Thinking { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ThinkingContent? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ThinkingContent PickThinking() => Thinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        /// Code content block (e.g. from code execution tools).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.CodeContent? Code { get; init; }
#else
        public global::PromptLayer.CodeContent? Code { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.CodeContent? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CodeContent PickCode() => Code is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ImageContent? ImageUrl { get; init; }
#else
        public global::PromptLayer.ImageContent? ImageUrl { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ImageContent? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ImageContent PickImageUrl() => ImageUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.MediaContent? Media { get; init; }
#else
        public global::PromptLayer.MediaContent? Media { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Media))]
#endif
        public bool IsMedia => Media != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMedia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.MediaContent? value)
        {
            value = Media;
            return IsMedia;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MediaContent PickMedia() => Media is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Media' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.MediaVariable? MediaVariable { get; init; }
#else
        public global::PromptLayer.MediaVariable? MediaVariable { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MediaVariable))]
#endif
        public bool IsMediaVariable => MediaVariable != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMediaVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.MediaVariable? value)
        {
            value = MediaVariable;
            return IsMediaVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MediaVariable PickMediaVariable() => MediaVariable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MediaVariable' but the value was {ToString()}.");

        /// <summary>
        /// LLM-generated media output (e.g. from image generation tools).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.OutputMediaContent? OutputMedia { get; init; }
#else
        public global::PromptLayer.OutputMediaContent? OutputMedia { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMedia))]
#endif
        public bool IsOutputMedia => OutputMedia != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputMedia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.OutputMediaContent? value)
        {
            value = OutputMedia;
            return IsOutputMedia;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OutputMediaContent PickOutputMedia() => OutputMedia is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMedia' but the value was {ToString()}.");

        /// <summary>
        /// Server-side tool use block (e.g. web search, code execution).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ServerToolUseContent? ServerToolUse { get; init; }
#else
        public global::PromptLayer.ServerToolUseContent? ServerToolUse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerToolUse))]
#endif
        public bool IsServerToolUse => ServerToolUse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickServerToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ServerToolUseContent? value)
        {
            value = ServerToolUse;
            return IsServerToolUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ServerToolUseContent PickServerToolUse() => ServerToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerToolUse' but the value was {ToString()}.");

        /// <summary>
        /// Results from a web search tool invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.WebSearchToolResultContent? WebSearchToolResult { get; init; }
#else
        public global::PromptLayer.WebSearchToolResultContent? WebSearchToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolResult))]
#endif
        public bool IsWebSearchToolResult => WebSearchToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.WebSearchToolResultContent? value)
        {
            value = WebSearchToolResult;
            return IsWebSearchToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.WebSearchToolResultContent PickWebSearchToolResult() => WebSearchToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Result from a code execution tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.CodeExecutionResultContent? CodeExecutionResult { get; init; }
#else
        public global::PromptLayer.CodeExecutionResultContent? CodeExecutionResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionResult))]
#endif
        public bool IsCodeExecutionResult => CodeExecutionResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.CodeExecutionResultContent? value)
        {
            value = CodeExecutionResult;
            return IsCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CodeExecutionResultContent PickCodeExecutionResult() => CodeExecutionResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionResult' but the value was {ToString()}.");

        /// <summary>
        /// MCP list tools response block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.McpListToolsContent? McpListTools { get; init; }
#else
        public global::PromptLayer.McpListToolsContent? McpListTools { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListTools))]
#endif
        public bool IsMcpListTools => McpListTools != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpListTools(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.McpListToolsContent? value)
        {
            value = McpListTools;
            return IsMcpListTools;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpListToolsContent PickMcpListTools() => McpListTools is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpListTools' but the value was {ToString()}.");

        /// <summary>
        /// MCP tool call block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.McpCallContent? McpCall { get; init; }
#else
        public global::PromptLayer.McpCallContent? McpCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpCall))]
#endif
        public bool IsMcpCall => McpCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.McpCallContent? value)
        {
            value = McpCall;
            return IsMcpCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpCallContent PickMcpCall() => McpCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpCall' but the value was {ToString()}.");

        /// <summary>
        /// MCP tool approval request block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.McpApprovalRequestContent? McpApprovalRequest { get; init; }
#else
        public global::PromptLayer.McpApprovalRequestContent? McpApprovalRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalRequest))]
#endif
        public bool IsMcpApprovalRequest => McpApprovalRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpApprovalRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.McpApprovalRequestContent? value)
        {
            value = McpApprovalRequest;
            return IsMcpApprovalRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpApprovalRequestContent PickMcpApprovalRequest() => McpApprovalRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpApprovalRequest' but the value was {ToString()}.");

        /// <summary>
        /// MCP tool approval response block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.McpApprovalResponseContent? McpApprovalResponse { get; init; }
#else
        public global::PromptLayer.McpApprovalResponseContent? McpApprovalResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponse))]
#endif
        public bool IsMcpApprovalResponse => McpApprovalResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpApprovalResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.McpApprovalResponseContent? value)
        {
            value = McpApprovalResponse;
            return IsMcpApprovalResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpApprovalResponseContent PickMcpApprovalResponse() => McpApprovalResponse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpApprovalResponse' but the value was {ToString()}.");

        /// <summary>
        /// Result from bash code execution tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.BashCodeExecutionToolResultContent? BashCodeExecutionToolResult { get; init; }
#else
        public global::PromptLayer.BashCodeExecutionToolResultContent? BashCodeExecutionToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashCodeExecutionToolResult))]
#endif
        public bool IsBashCodeExecutionToolResult => BashCodeExecutionToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBashCodeExecutionToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.BashCodeExecutionToolResultContent? value)
        {
            value = BashCodeExecutionToolResult;
            return IsBashCodeExecutionToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.BashCodeExecutionToolResultContent PickBashCodeExecutionToolResult() => BashCodeExecutionToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Result from text editor code execution tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.TextEditorCodeExecutionToolResultContent? TextEditorCodeExecutionToolResult { get; init; }
#else
        public global::PromptLayer.TextEditorCodeExecutionToolResultContent? TextEditorCodeExecutionToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionToolResult))]
#endif
        public bool IsTextEditorCodeExecutionToolResult => TextEditorCodeExecutionToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextEditorCodeExecutionToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.TextEditorCodeExecutionToolResultContent? value)
        {
            value = TextEditorCodeExecutionToolResult;
            return IsTextEditorCodeExecutionToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TextEditorCodeExecutionToolResultContent PickTextEditorCodeExecutionToolResult() => TextEditorCodeExecutionToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Shell tool call block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ShellCallContent? ShellCall { get; init; }
#else
        public global::PromptLayer.ShellCallContent? ShellCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCall))]
#endif
        public bool IsShellCall => ShellCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShellCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ShellCallContent? value)
        {
            value = ShellCall;
            return IsShellCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ShellCallContent PickShellCall() => ShellCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCall' but the value was {ToString()}.");

        /// <summary>
        /// Shell tool output block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ShellCallOutputContent? ShellCallOutput { get; init; }
#else
        public global::PromptLayer.ShellCallOutputContent? ShellCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallOutput))]
#endif
        public bool IsShellCallOutput => ShellCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShellCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ShellCallOutputContent? value)
        {
            value = ShellCallOutput;
            return IsShellCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ShellCallOutputContent PickShellCallOutput() => ShellCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Apply patch tool call block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ApplyPatchCallContent? ApplyPatchCall { get; init; }
#else
        public global::PromptLayer.ApplyPatchCallContent? ApplyPatchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCall))]
#endif
        public bool IsApplyPatchCall => ApplyPatchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApplyPatchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ApplyPatchCallContent? value)
        {
            value = ApplyPatchCall;
            return IsApplyPatchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ApplyPatchCallContent PickApplyPatchCall() => ApplyPatchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCall' but the value was {ToString()}.");

        /// <summary>
        /// Apply patch tool output block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ApplyPatchCallOutputContent? ApplyPatchCallOutput { get; init; }
#else
        public global::PromptLayer.ApplyPatchCallOutputContent? ApplyPatchCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutput))]
#endif
        public bool IsApplyPatchCallOutput => ApplyPatchCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApplyPatchCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ApplyPatchCallOutputContent? value)
        {
            value = ApplyPatchCallOutput;
            return IsApplyPatchCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ApplyPatchCallOutputContent PickApplyPatchCallOutput() => ApplyPatchCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOutput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.TextContent value) => new ContentItem4((global::PromptLayer.TextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.TextContent?(ContentItem4 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromText(global::PromptLayer.TextContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.ThinkingContent value) => new ContentItem4((global::PromptLayer.ThinkingContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.ThinkingContent?(ContentItem4 @this) => @this.Thinking;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.ThinkingContent? value)
        {
            Thinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromThinking(global::PromptLayer.ThinkingContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.CodeContent value) => new ContentItem4((global::PromptLayer.CodeContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.CodeContent?(ContentItem4 @this) => @this.Code;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.CodeContent? value)
        {
            Code = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromCode(global::PromptLayer.CodeContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.ImageContent value) => new ContentItem4((global::PromptLayer.ImageContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.ImageContent?(ContentItem4 @this) => @this.ImageUrl;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.ImageContent? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromImageUrl(global::PromptLayer.ImageContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.MediaContent value) => new ContentItem4((global::PromptLayer.MediaContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.MediaContent?(ContentItem4 @this) => @this.Media;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.MediaContent? value)
        {
            Media = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromMedia(global::PromptLayer.MediaContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.MediaVariable value) => new ContentItem4((global::PromptLayer.MediaVariable?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.MediaVariable?(ContentItem4 @this) => @this.MediaVariable;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.MediaVariable? value)
        {
            MediaVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromMediaVariable(global::PromptLayer.MediaVariable? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.OutputMediaContent value) => new ContentItem4((global::PromptLayer.OutputMediaContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.OutputMediaContent?(ContentItem4 @this) => @this.OutputMedia;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.OutputMediaContent? value)
        {
            OutputMedia = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromOutputMedia(global::PromptLayer.OutputMediaContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.ServerToolUseContent value) => new ContentItem4((global::PromptLayer.ServerToolUseContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.ServerToolUseContent?(ContentItem4 @this) => @this.ServerToolUse;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.ServerToolUseContent? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromServerToolUse(global::PromptLayer.ServerToolUseContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.WebSearchToolResultContent value) => new ContentItem4((global::PromptLayer.WebSearchToolResultContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.WebSearchToolResultContent?(ContentItem4 @this) => @this.WebSearchToolResult;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.WebSearchToolResultContent? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromWebSearchToolResult(global::PromptLayer.WebSearchToolResultContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.CodeExecutionResultContent value) => new ContentItem4((global::PromptLayer.CodeExecutionResultContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.CodeExecutionResultContent?(ContentItem4 @this) => @this.CodeExecutionResult;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.CodeExecutionResultContent? value)
        {
            CodeExecutionResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromCodeExecutionResult(global::PromptLayer.CodeExecutionResultContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.McpListToolsContent value) => new ContentItem4((global::PromptLayer.McpListToolsContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.McpListToolsContent?(ContentItem4 @this) => @this.McpListTools;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.McpListToolsContent? value)
        {
            McpListTools = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromMcpListTools(global::PromptLayer.McpListToolsContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.McpCallContent value) => new ContentItem4((global::PromptLayer.McpCallContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.McpCallContent?(ContentItem4 @this) => @this.McpCall;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.McpCallContent? value)
        {
            McpCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromMcpCall(global::PromptLayer.McpCallContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.McpApprovalRequestContent value) => new ContentItem4((global::PromptLayer.McpApprovalRequestContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.McpApprovalRequestContent?(ContentItem4 @this) => @this.McpApprovalRequest;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.McpApprovalRequestContent? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromMcpApprovalRequest(global::PromptLayer.McpApprovalRequestContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.McpApprovalResponseContent value) => new ContentItem4((global::PromptLayer.McpApprovalResponseContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.McpApprovalResponseContent?(ContentItem4 @this) => @this.McpApprovalResponse;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.McpApprovalResponseContent? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromMcpApprovalResponse(global::PromptLayer.McpApprovalResponseContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.BashCodeExecutionToolResultContent value) => new ContentItem4((global::PromptLayer.BashCodeExecutionToolResultContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.BashCodeExecutionToolResultContent?(ContentItem4 @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.BashCodeExecutionToolResultContent? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromBashCodeExecutionToolResult(global::PromptLayer.BashCodeExecutionToolResultContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.TextEditorCodeExecutionToolResultContent value) => new ContentItem4((global::PromptLayer.TextEditorCodeExecutionToolResultContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.TextEditorCodeExecutionToolResultContent?(ContentItem4 @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.TextEditorCodeExecutionToolResultContent? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromTextEditorCodeExecutionToolResult(global::PromptLayer.TextEditorCodeExecutionToolResultContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.ShellCallContent value) => new ContentItem4((global::PromptLayer.ShellCallContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.ShellCallContent?(ContentItem4 @this) => @this.ShellCall;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.ShellCallContent? value)
        {
            ShellCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromShellCall(global::PromptLayer.ShellCallContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.ShellCallOutputContent value) => new ContentItem4((global::PromptLayer.ShellCallOutputContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.ShellCallOutputContent?(ContentItem4 @this) => @this.ShellCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.ShellCallOutputContent? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromShellCallOutput(global::PromptLayer.ShellCallOutputContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.ApplyPatchCallContent value) => new ContentItem4((global::PromptLayer.ApplyPatchCallContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.ApplyPatchCallContent?(ContentItem4 @this) => @this.ApplyPatchCall;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.ApplyPatchCallContent? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromApplyPatchCall(global::PromptLayer.ApplyPatchCallContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::PromptLayer.ApplyPatchCallOutputContent value) => new ContentItem4((global::PromptLayer.ApplyPatchCallOutputContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.ApplyPatchCallOutputContent?(ContentItem4 @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::PromptLayer.ApplyPatchCallOutputContent? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromApplyPatchCallOutput(global::PromptLayer.ApplyPatchCallOutputContent? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(
            global::PromptLayer.DeveloperMessageContentItemDiscriminatorType? type,
            global::PromptLayer.TextContent? text,
            global::PromptLayer.ThinkingContent? thinking,
            global::PromptLayer.CodeContent? code,
            global::PromptLayer.ImageContent? imageUrl,
            global::PromptLayer.MediaContent? media,
            global::PromptLayer.MediaVariable? mediaVariable,
            global::PromptLayer.OutputMediaContent? outputMedia,
            global::PromptLayer.ServerToolUseContent? serverToolUse,
            global::PromptLayer.WebSearchToolResultContent? webSearchToolResult,
            global::PromptLayer.CodeExecutionResultContent? codeExecutionResult,
            global::PromptLayer.McpListToolsContent? mcpListTools,
            global::PromptLayer.McpCallContent? mcpCall,
            global::PromptLayer.McpApprovalRequestContent? mcpApprovalRequest,
            global::PromptLayer.McpApprovalResponseContent? mcpApprovalResponse,
            global::PromptLayer.BashCodeExecutionToolResultContent? bashCodeExecutionToolResult,
            global::PromptLayer.TextEditorCodeExecutionToolResultContent? textEditorCodeExecutionToolResult,
            global::PromptLayer.ShellCallContent? shellCall,
            global::PromptLayer.ShellCallOutputContent? shellCallOutput,
            global::PromptLayer.ApplyPatchCallContent? applyPatchCall,
            global::PromptLayer.ApplyPatchCallOutputContent? applyPatchCallOutput
            )
        {
            Type = type;

            Text = text;
            Thinking = thinking;
            Code = code;
            ImageUrl = imageUrl;
            Media = media;
            MediaVariable = mediaVariable;
            OutputMedia = outputMedia;
            ServerToolUse = serverToolUse;
            WebSearchToolResult = webSearchToolResult;
            CodeExecutionResult = codeExecutionResult;
            McpListTools = mcpListTools;
            McpCall = mcpCall;
            McpApprovalRequest = mcpApprovalRequest;
            McpApprovalResponse = mcpApprovalResponse;
            BashCodeExecutionToolResult = bashCodeExecutionToolResult;
            TextEditorCodeExecutionToolResult = textEditorCodeExecutionToolResult;
            ShellCall = shellCall;
            ShellCallOutput = shellCallOutput;
            ApplyPatchCall = applyPatchCall;
            ApplyPatchCallOutput = applyPatchCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ApplyPatchCallOutput as object ??
            ApplyPatchCall as object ??
            ShellCallOutput as object ??
            ShellCall as object ??
            TextEditorCodeExecutionToolResult as object ??
            BashCodeExecutionToolResult as object ??
            McpApprovalResponse as object ??
            McpApprovalRequest as object ??
            McpCall as object ??
            McpListTools as object ??
            CodeExecutionResult as object ??
            WebSearchToolResult as object ??
            ServerToolUse as object ??
            OutputMedia as object ??
            MediaVariable as object ??
            Media as object ??
            ImageUrl as object ??
            Code as object ??
            Thinking as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Thinking?.ToString() ??
            Code?.ToString() ??
            ImageUrl?.ToString() ??
            Media?.ToString() ??
            MediaVariable?.ToString() ??
            OutputMedia?.ToString() ??
            ServerToolUse?.ToString() ??
            WebSearchToolResult?.ToString() ??
            CodeExecutionResult?.ToString() ??
            McpListTools?.ToString() ??
            McpCall?.ToString() ??
            McpApprovalRequest?.ToString() ??
            McpApprovalResponse?.ToString() ??
            BashCodeExecutionToolResult?.ToString() ??
            TextEditorCodeExecutionToolResult?.ToString() ??
            ShellCall?.ToString() ??
            ShellCallOutput?.ToString() ??
            ApplyPatchCall?.ToString() ??
            ApplyPatchCallOutput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && IsApplyPatchCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::PromptLayer.TextContent, TResult>? text = null,
            global::System.Func<global::PromptLayer.ThinkingContent, TResult>? thinking = null,
            global::System.Func<global::PromptLayer.CodeContent, TResult>? code = null,
            global::System.Func<global::PromptLayer.ImageContent, TResult>? imageUrl = null,
            global::System.Func<global::PromptLayer.MediaContent, TResult>? media = null,
            global::System.Func<global::PromptLayer.MediaVariable, TResult>? mediaVariable = null,
            global::System.Func<global::PromptLayer.OutputMediaContent, TResult>? outputMedia = null,
            global::System.Func<global::PromptLayer.ServerToolUseContent, TResult>? serverToolUse = null,
            global::System.Func<global::PromptLayer.WebSearchToolResultContent, TResult>? webSearchToolResult = null,
            global::System.Func<global::PromptLayer.CodeExecutionResultContent, TResult>? codeExecutionResult = null,
            global::System.Func<global::PromptLayer.McpListToolsContent, TResult>? mcpListTools = null,
            global::System.Func<global::PromptLayer.McpCallContent, TResult>? mcpCall = null,
            global::System.Func<global::PromptLayer.McpApprovalRequestContent, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::PromptLayer.McpApprovalResponseContent, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::PromptLayer.BashCodeExecutionToolResultContent, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::PromptLayer.TextEditorCodeExecutionToolResultContent, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::PromptLayer.ShellCallContent, TResult>? shellCall = null,
            global::System.Func<global::PromptLayer.ShellCallOutputContent, TResult>? shellCallOutput = null,
            global::System.Func<global::PromptLayer.ApplyPatchCallContent, TResult>? applyPatchCall = null,
            global::System.Func<global::PromptLayer.ApplyPatchCallOutputContent, TResult>? applyPatchCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Thinking is { } __value1 && thinking != null)
            {
                return thinking(__value1);
            }
            else if (Code is { } __value2 && code != null)
            {
                return code(__value2);
            }
            else if (ImageUrl is { } __value3 && imageUrl != null)
            {
                return imageUrl(__value3);
            }
            else if (Media is { } __value4 && media != null)
            {
                return media(__value4);
            }
            else if (MediaVariable is { } __value5 && mediaVariable != null)
            {
                return mediaVariable(__value5);
            }
            else if (OutputMedia is { } __value6 && outputMedia != null)
            {
                return outputMedia(__value6);
            }
            else if (ServerToolUse is { } __value7 && serverToolUse != null)
            {
                return serverToolUse(__value7);
            }
            else if (WebSearchToolResult is { } __value8 && webSearchToolResult != null)
            {
                return webSearchToolResult(__value8);
            }
            else if (CodeExecutionResult is { } __value9 && codeExecutionResult != null)
            {
                return codeExecutionResult(__value9);
            }
            else if (McpListTools is { } __value10 && mcpListTools != null)
            {
                return mcpListTools(__value10);
            }
            else if (McpCall is { } __value11 && mcpCall != null)
            {
                return mcpCall(__value11);
            }
            else if (McpApprovalRequest is { } __value12 && mcpApprovalRequest != null)
            {
                return mcpApprovalRequest(__value12);
            }
            else if (McpApprovalResponse is { } __value13 && mcpApprovalResponse != null)
            {
                return mcpApprovalResponse(__value13);
            }
            else if (BashCodeExecutionToolResult is { } __value14 && bashCodeExecutionToolResult != null)
            {
                return bashCodeExecutionToolResult(__value14);
            }
            else if (TextEditorCodeExecutionToolResult is { } __value15 && textEditorCodeExecutionToolResult != null)
            {
                return textEditorCodeExecutionToolResult(__value15);
            }
            else if (ShellCall is { } __value16 && shellCall != null)
            {
                return shellCall(__value16);
            }
            else if (ShellCallOutput is { } __value17 && shellCallOutput != null)
            {
                return shellCallOutput(__value17);
            }
            else if (ApplyPatchCall is { } __value18 && applyPatchCall != null)
            {
                return applyPatchCall(__value18);
            }
            else if (ApplyPatchCallOutput is { } __value19 && applyPatchCallOutput != null)
            {
                return applyPatchCallOutput(__value19);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::PromptLayer.TextContent>? text = null,

            global::System.Action<global::PromptLayer.ThinkingContent>? thinking = null,

            global::System.Action<global::PromptLayer.CodeContent>? code = null,

            global::System.Action<global::PromptLayer.ImageContent>? imageUrl = null,

            global::System.Action<global::PromptLayer.MediaContent>? media = null,

            global::System.Action<global::PromptLayer.MediaVariable>? mediaVariable = null,

            global::System.Action<global::PromptLayer.OutputMediaContent>? outputMedia = null,

            global::System.Action<global::PromptLayer.ServerToolUseContent>? serverToolUse = null,

            global::System.Action<global::PromptLayer.WebSearchToolResultContent>? webSearchToolResult = null,

            global::System.Action<global::PromptLayer.CodeExecutionResultContent>? codeExecutionResult = null,

            global::System.Action<global::PromptLayer.McpListToolsContent>? mcpListTools = null,

            global::System.Action<global::PromptLayer.McpCallContent>? mcpCall = null,

            global::System.Action<global::PromptLayer.McpApprovalRequestContent>? mcpApprovalRequest = null,

            global::System.Action<global::PromptLayer.McpApprovalResponseContent>? mcpApprovalResponse = null,

            global::System.Action<global::PromptLayer.BashCodeExecutionToolResultContent>? bashCodeExecutionToolResult = null,

            global::System.Action<global::PromptLayer.TextEditorCodeExecutionToolResultContent>? textEditorCodeExecutionToolResult = null,

            global::System.Action<global::PromptLayer.ShellCallContent>? shellCall = null,

            global::System.Action<global::PromptLayer.ShellCallOutputContent>? shellCallOutput = null,

            global::System.Action<global::PromptLayer.ApplyPatchCallContent>? applyPatchCall = null,

            global::System.Action<global::PromptLayer.ApplyPatchCallOutputContent>? applyPatchCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Thinking is { } __value1)
            {
                thinking?.Invoke(__value1);
            }
            else if (Code is { } __value2)
            {
                code?.Invoke(__value2);
            }
            else if (ImageUrl is { } __value3)
            {
                imageUrl?.Invoke(__value3);
            }
            else if (Media is { } __value4)
            {
                media?.Invoke(__value4);
            }
            else if (MediaVariable is { } __value5)
            {
                mediaVariable?.Invoke(__value5);
            }
            else if (OutputMedia is { } __value6)
            {
                outputMedia?.Invoke(__value6);
            }
            else if (ServerToolUse is { } __value7)
            {
                serverToolUse?.Invoke(__value7);
            }
            else if (WebSearchToolResult is { } __value8)
            {
                webSearchToolResult?.Invoke(__value8);
            }
            else if (CodeExecutionResult is { } __value9)
            {
                codeExecutionResult?.Invoke(__value9);
            }
            else if (McpListTools is { } __value10)
            {
                mcpListTools?.Invoke(__value10);
            }
            else if (McpCall is { } __value11)
            {
                mcpCall?.Invoke(__value11);
            }
            else if (McpApprovalRequest is { } __value12)
            {
                mcpApprovalRequest?.Invoke(__value12);
            }
            else if (McpApprovalResponse is { } __value13)
            {
                mcpApprovalResponse?.Invoke(__value13);
            }
            else if (BashCodeExecutionToolResult is { } __value14)
            {
                bashCodeExecutionToolResult?.Invoke(__value14);
            }
            else if (TextEditorCodeExecutionToolResult is { } __value15)
            {
                textEditorCodeExecutionToolResult?.Invoke(__value15);
            }
            else if (ShellCall is { } __value16)
            {
                shellCall?.Invoke(__value16);
            }
            else if (ShellCallOutput is { } __value17)
            {
                shellCallOutput?.Invoke(__value17);
            }
            else if (ApplyPatchCall is { } __value18)
            {
                applyPatchCall?.Invoke(__value18);
            }
            else if (ApplyPatchCallOutput is { } __value19)
            {
                applyPatchCallOutput?.Invoke(__value19);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::PromptLayer.TextContent>? text = null,
            global::System.Action<global::PromptLayer.ThinkingContent>? thinking = null,
            global::System.Action<global::PromptLayer.CodeContent>? code = null,
            global::System.Action<global::PromptLayer.ImageContent>? imageUrl = null,
            global::System.Action<global::PromptLayer.MediaContent>? media = null,
            global::System.Action<global::PromptLayer.MediaVariable>? mediaVariable = null,
            global::System.Action<global::PromptLayer.OutputMediaContent>? outputMedia = null,
            global::System.Action<global::PromptLayer.ServerToolUseContent>? serverToolUse = null,
            global::System.Action<global::PromptLayer.WebSearchToolResultContent>? webSearchToolResult = null,
            global::System.Action<global::PromptLayer.CodeExecutionResultContent>? codeExecutionResult = null,
            global::System.Action<global::PromptLayer.McpListToolsContent>? mcpListTools = null,
            global::System.Action<global::PromptLayer.McpCallContent>? mcpCall = null,
            global::System.Action<global::PromptLayer.McpApprovalRequestContent>? mcpApprovalRequest = null,
            global::System.Action<global::PromptLayer.McpApprovalResponseContent>? mcpApprovalResponse = null,
            global::System.Action<global::PromptLayer.BashCodeExecutionToolResultContent>? bashCodeExecutionToolResult = null,
            global::System.Action<global::PromptLayer.TextEditorCodeExecutionToolResultContent>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::PromptLayer.ShellCallContent>? shellCall = null,
            global::System.Action<global::PromptLayer.ShellCallOutputContent>? shellCallOutput = null,
            global::System.Action<global::PromptLayer.ApplyPatchCallContent>? applyPatchCall = null,
            global::System.Action<global::PromptLayer.ApplyPatchCallOutputContent>? applyPatchCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Thinking is { } __value1)
            {
                thinking?.Invoke(__value1);
            }
            else if (Code is { } __value2)
            {
                code?.Invoke(__value2);
            }
            else if (ImageUrl is { } __value3)
            {
                imageUrl?.Invoke(__value3);
            }
            else if (Media is { } __value4)
            {
                media?.Invoke(__value4);
            }
            else if (MediaVariable is { } __value5)
            {
                mediaVariable?.Invoke(__value5);
            }
            else if (OutputMedia is { } __value6)
            {
                outputMedia?.Invoke(__value6);
            }
            else if (ServerToolUse is { } __value7)
            {
                serverToolUse?.Invoke(__value7);
            }
            else if (WebSearchToolResult is { } __value8)
            {
                webSearchToolResult?.Invoke(__value8);
            }
            else if (CodeExecutionResult is { } __value9)
            {
                codeExecutionResult?.Invoke(__value9);
            }
            else if (McpListTools is { } __value10)
            {
                mcpListTools?.Invoke(__value10);
            }
            else if (McpCall is { } __value11)
            {
                mcpCall?.Invoke(__value11);
            }
            else if (McpApprovalRequest is { } __value12)
            {
                mcpApprovalRequest?.Invoke(__value12);
            }
            else if (McpApprovalResponse is { } __value13)
            {
                mcpApprovalResponse?.Invoke(__value13);
            }
            else if (BashCodeExecutionToolResult is { } __value14)
            {
                bashCodeExecutionToolResult?.Invoke(__value14);
            }
            else if (TextEditorCodeExecutionToolResult is { } __value15)
            {
                textEditorCodeExecutionToolResult?.Invoke(__value15);
            }
            else if (ShellCall is { } __value16)
            {
                shellCall?.Invoke(__value16);
            }
            else if (ShellCallOutput is { } __value17)
            {
                shellCallOutput?.Invoke(__value17);
            }
            else if (ApplyPatchCall is { } __value18)
            {
                applyPatchCall?.Invoke(__value18);
            }
            else if (ApplyPatchCallOutput is { } __value19)
            {
                applyPatchCallOutput?.Invoke(__value19);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::PromptLayer.TextContent),
                Thinking,
                typeof(global::PromptLayer.ThinkingContent),
                Code,
                typeof(global::PromptLayer.CodeContent),
                ImageUrl,
                typeof(global::PromptLayer.ImageContent),
                Media,
                typeof(global::PromptLayer.MediaContent),
                MediaVariable,
                typeof(global::PromptLayer.MediaVariable),
                OutputMedia,
                typeof(global::PromptLayer.OutputMediaContent),
                ServerToolUse,
                typeof(global::PromptLayer.ServerToolUseContent),
                WebSearchToolResult,
                typeof(global::PromptLayer.WebSearchToolResultContent),
                CodeExecutionResult,
                typeof(global::PromptLayer.CodeExecutionResultContent),
                McpListTools,
                typeof(global::PromptLayer.McpListToolsContent),
                McpCall,
                typeof(global::PromptLayer.McpCallContent),
                McpApprovalRequest,
                typeof(global::PromptLayer.McpApprovalRequestContent),
                McpApprovalResponse,
                typeof(global::PromptLayer.McpApprovalResponseContent),
                BashCodeExecutionToolResult,
                typeof(global::PromptLayer.BashCodeExecutionToolResultContent),
                TextEditorCodeExecutionToolResult,
                typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContent),
                ShellCall,
                typeof(global::PromptLayer.ShellCallContent),
                ShellCallOutput,
                typeof(global::PromptLayer.ShellCallOutputContent),
                ApplyPatchCall,
                typeof(global::PromptLayer.ApplyPatchCallContent),
                ApplyPatchCallOutput,
                typeof(global::PromptLayer.ApplyPatchCallOutputContent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ContentItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ThinkingContent?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.CodeContent?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ImageContent?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.MediaContent?>.Default.Equals(Media, other.Media) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.MediaVariable?>.Default.Equals(MediaVariable, other.MediaVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.OutputMediaContent?>.Default.Equals(OutputMedia, other.OutputMedia) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ServerToolUseContent?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.WebSearchToolResultContent?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.CodeExecutionResultContent?>.Default.Equals(CodeExecutionResult, other.CodeExecutionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.McpListToolsContent?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.McpCallContent?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.McpApprovalRequestContent?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.McpApprovalResponseContent?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.BashCodeExecutionToolResultContent?>.Default.Equals(BashCodeExecutionToolResult, other.BashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.TextEditorCodeExecutionToolResultContent?>.Default.Equals(TextEditorCodeExecutionToolResult, other.TextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ShellCallContent?>.Default.Equals(ShellCall, other.ShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ShellCallOutputContent?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ApplyPatchCallContent?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ApplyPatchCallOutputContent?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentItem4 obj1, ContentItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentItem4 obj1, ContentItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem4 o && Equals(o);
        }
    }
}
