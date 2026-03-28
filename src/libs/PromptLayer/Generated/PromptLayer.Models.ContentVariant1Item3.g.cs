#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant1Item3 : global::System.IEquatable<ContentVariant1Item3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType? Type { get; }

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
        public static implicit operator ContentVariant1Item3(global::PromptLayer.TextContent value) => new ContentVariant1Item3((global::PromptLayer.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.TextContent?(ContentVariant1Item3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.ThinkingContent value) => new ContentVariant1Item3((global::PromptLayer.ThinkingContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ThinkingContent?(ContentVariant1Item3 @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.ThinkingContent? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.CodeContent value) => new ContentVariant1Item3((global::PromptLayer.CodeContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.CodeContent?(ContentVariant1Item3 @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.CodeContent? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.ImageContent value) => new ContentVariant1Item3((global::PromptLayer.ImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ImageContent?(ContentVariant1Item3 @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.ImageContent? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.MediaContent value) => new ContentVariant1Item3((global::PromptLayer.MediaContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.MediaContent?(ContentVariant1Item3 @this) => @this.Media;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.MediaContent? value)
        {
            Media = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.MediaVariable value) => new ContentVariant1Item3((global::PromptLayer.MediaVariable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.MediaVariable?(ContentVariant1Item3 @this) => @this.MediaVariable;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.MediaVariable? value)
        {
            MediaVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.OutputMediaContent value) => new ContentVariant1Item3((global::PromptLayer.OutputMediaContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.OutputMediaContent?(ContentVariant1Item3 @this) => @this.OutputMedia;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.OutputMediaContent? value)
        {
            OutputMedia = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.ServerToolUseContent value) => new ContentVariant1Item3((global::PromptLayer.ServerToolUseContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ServerToolUseContent?(ContentVariant1Item3 @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.ServerToolUseContent? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.WebSearchToolResultContent value) => new ContentVariant1Item3((global::PromptLayer.WebSearchToolResultContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.WebSearchToolResultContent?(ContentVariant1Item3 @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.WebSearchToolResultContent? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.CodeExecutionResultContent value) => new ContentVariant1Item3((global::PromptLayer.CodeExecutionResultContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.CodeExecutionResultContent?(ContentVariant1Item3 @this) => @this.CodeExecutionResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.CodeExecutionResultContent? value)
        {
            CodeExecutionResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.McpListToolsContent value) => new ContentVariant1Item3((global::PromptLayer.McpListToolsContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.McpListToolsContent?(ContentVariant1Item3 @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.McpListToolsContent? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.McpCallContent value) => new ContentVariant1Item3((global::PromptLayer.McpCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.McpCallContent?(ContentVariant1Item3 @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.McpCallContent? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.McpApprovalRequestContent value) => new ContentVariant1Item3((global::PromptLayer.McpApprovalRequestContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.McpApprovalRequestContent?(ContentVariant1Item3 @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.McpApprovalRequestContent? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.McpApprovalResponseContent value) => new ContentVariant1Item3((global::PromptLayer.McpApprovalResponseContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.McpApprovalResponseContent?(ContentVariant1Item3 @this) => @this.McpApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.McpApprovalResponseContent? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.BashCodeExecutionToolResultContent value) => new ContentVariant1Item3((global::PromptLayer.BashCodeExecutionToolResultContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.BashCodeExecutionToolResultContent?(ContentVariant1Item3 @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.BashCodeExecutionToolResultContent? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.TextEditorCodeExecutionToolResultContent value) => new ContentVariant1Item3((global::PromptLayer.TextEditorCodeExecutionToolResultContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.TextEditorCodeExecutionToolResultContent?(ContentVariant1Item3 @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.TextEditorCodeExecutionToolResultContent? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.ShellCallContent value) => new ContentVariant1Item3((global::PromptLayer.ShellCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ShellCallContent?(ContentVariant1Item3 @this) => @this.ShellCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.ShellCallContent? value)
        {
            ShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.ShellCallOutputContent value) => new ContentVariant1Item3((global::PromptLayer.ShellCallOutputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ShellCallOutputContent?(ContentVariant1Item3 @this) => @this.ShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.ShellCallOutputContent? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.ApplyPatchCallContent value) => new ContentVariant1Item3((global::PromptLayer.ApplyPatchCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ApplyPatchCallContent?(ContentVariant1Item3 @this) => @this.ApplyPatchCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.ApplyPatchCallContent? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item3(global::PromptLayer.ApplyPatchCallOutputContent value) => new ContentVariant1Item3((global::PromptLayer.ApplyPatchCallOutputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ApplyPatchCallOutputContent?(ContentVariant1Item3 @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(global::PromptLayer.ApplyPatchCallOutputContent? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item3(
            global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType? type,
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
            global::System.Func<global::PromptLayer.TextContent?, TResult>? text = null,
            global::System.Func<global::PromptLayer.ThinkingContent?, TResult>? thinking = null,
            global::System.Func<global::PromptLayer.CodeContent?, TResult>? code = null,
            global::System.Func<global::PromptLayer.ImageContent?, TResult>? imageUrl = null,
            global::System.Func<global::PromptLayer.MediaContent?, TResult>? media = null,
            global::System.Func<global::PromptLayer.MediaVariable?, TResult>? mediaVariable = null,
            global::System.Func<global::PromptLayer.OutputMediaContent?, TResult>? outputMedia = null,
            global::System.Func<global::PromptLayer.ServerToolUseContent?, TResult>? serverToolUse = null,
            global::System.Func<global::PromptLayer.WebSearchToolResultContent?, TResult>? webSearchToolResult = null,
            global::System.Func<global::PromptLayer.CodeExecutionResultContent?, TResult>? codeExecutionResult = null,
            global::System.Func<global::PromptLayer.McpListToolsContent?, TResult>? mcpListTools = null,
            global::System.Func<global::PromptLayer.McpCallContent?, TResult>? mcpCall = null,
            global::System.Func<global::PromptLayer.McpApprovalRequestContent?, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::PromptLayer.McpApprovalResponseContent?, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::PromptLayer.BashCodeExecutionToolResultContent?, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::PromptLayer.TextEditorCodeExecutionToolResultContent?, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::PromptLayer.ShellCallContent?, TResult>? shellCall = null,
            global::System.Func<global::PromptLayer.ShellCallOutputContent?, TResult>? shellCallOutput = null,
            global::System.Func<global::PromptLayer.ApplyPatchCallContent?, TResult>? applyPatchCall = null,
            global::System.Func<global::PromptLayer.ApplyPatchCallOutputContent?, TResult>? applyPatchCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsMedia && media != null)
            {
                return media(Media!);
            }
            else if (IsMediaVariable && mediaVariable != null)
            {
                return mediaVariable(MediaVariable!);
            }
            else if (IsOutputMedia && outputMedia != null)
            {
                return outputMedia(OutputMedia!);
            }
            else if (IsServerToolUse && serverToolUse != null)
            {
                return serverToolUse(ServerToolUse!);
            }
            else if (IsWebSearchToolResult && webSearchToolResult != null)
            {
                return webSearchToolResult(WebSearchToolResult!);
            }
            else if (IsCodeExecutionResult && codeExecutionResult != null)
            {
                return codeExecutionResult(CodeExecutionResult!);
            }
            else if (IsMcpListTools && mcpListTools != null)
            {
                return mcpListTools(McpListTools!);
            }
            else if (IsMcpCall && mcpCall != null)
            {
                return mcpCall(McpCall!);
            }
            else if (IsMcpApprovalRequest && mcpApprovalRequest != null)
            {
                return mcpApprovalRequest(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse && mcpApprovalResponse != null)
            {
                return mcpApprovalResponse(McpApprovalResponse!);
            }
            else if (IsBashCodeExecutionToolResult && bashCodeExecutionToolResult != null)
            {
                return bashCodeExecutionToolResult(BashCodeExecutionToolResult!);
            }
            else if (IsTextEditorCodeExecutionToolResult && textEditorCodeExecutionToolResult != null)
            {
                return textEditorCodeExecutionToolResult(TextEditorCodeExecutionToolResult!);
            }
            else if (IsShellCall && shellCall != null)
            {
                return shellCall(ShellCall!);
            }
            else if (IsShellCallOutput && shellCallOutput != null)
            {
                return shellCallOutput(ShellCallOutput!);
            }
            else if (IsApplyPatchCall && applyPatchCall != null)
            {
                return applyPatchCall(ApplyPatchCall!);
            }
            else if (IsApplyPatchCallOutput && applyPatchCallOutput != null)
            {
                return applyPatchCallOutput(ApplyPatchCallOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::PromptLayer.TextContent?>? text = null,
            global::System.Action<global::PromptLayer.ThinkingContent?>? thinking = null,
            global::System.Action<global::PromptLayer.CodeContent?>? code = null,
            global::System.Action<global::PromptLayer.ImageContent?>? imageUrl = null,
            global::System.Action<global::PromptLayer.MediaContent?>? media = null,
            global::System.Action<global::PromptLayer.MediaVariable?>? mediaVariable = null,
            global::System.Action<global::PromptLayer.OutputMediaContent?>? outputMedia = null,
            global::System.Action<global::PromptLayer.ServerToolUseContent?>? serverToolUse = null,
            global::System.Action<global::PromptLayer.WebSearchToolResultContent?>? webSearchToolResult = null,
            global::System.Action<global::PromptLayer.CodeExecutionResultContent?>? codeExecutionResult = null,
            global::System.Action<global::PromptLayer.McpListToolsContent?>? mcpListTools = null,
            global::System.Action<global::PromptLayer.McpCallContent?>? mcpCall = null,
            global::System.Action<global::PromptLayer.McpApprovalRequestContent?>? mcpApprovalRequest = null,
            global::System.Action<global::PromptLayer.McpApprovalResponseContent?>? mcpApprovalResponse = null,
            global::System.Action<global::PromptLayer.BashCodeExecutionToolResultContent?>? bashCodeExecutionToolResult = null,
            global::System.Action<global::PromptLayer.TextEditorCodeExecutionToolResultContent?>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::PromptLayer.ShellCallContent?>? shellCall = null,
            global::System.Action<global::PromptLayer.ShellCallOutputContent?>? shellCallOutput = null,
            global::System.Action<global::PromptLayer.ApplyPatchCallContent?>? applyPatchCall = null,
            global::System.Action<global::PromptLayer.ApplyPatchCallOutputContent?>? applyPatchCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsMedia)
            {
                media?.Invoke(Media!);
            }
            else if (IsMediaVariable)
            {
                mediaVariable?.Invoke(MediaVariable!);
            }
            else if (IsOutputMedia)
            {
                outputMedia?.Invoke(OutputMedia!);
            }
            else if (IsServerToolUse)
            {
                serverToolUse?.Invoke(ServerToolUse!);
            }
            else if (IsWebSearchToolResult)
            {
                webSearchToolResult?.Invoke(WebSearchToolResult!);
            }
            else if (IsCodeExecutionResult)
            {
                codeExecutionResult?.Invoke(CodeExecutionResult!);
            }
            else if (IsMcpListTools)
            {
                mcpListTools?.Invoke(McpListTools!);
            }
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
            else if (IsMcpApprovalRequest)
            {
                mcpApprovalRequest?.Invoke(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse)
            {
                mcpApprovalResponse?.Invoke(McpApprovalResponse!);
            }
            else if (IsBashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult?.Invoke(BashCodeExecutionToolResult!);
            }
            else if (IsTextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult?.Invoke(TextEditorCodeExecutionToolResult!);
            }
            else if (IsShellCall)
            {
                shellCall?.Invoke(ShellCall!);
            }
            else if (IsShellCallOutput)
            {
                shellCallOutput?.Invoke(ShellCallOutput!);
            }
            else if (IsApplyPatchCall)
            {
                applyPatchCall?.Invoke(ApplyPatchCall!);
            }
            else if (IsApplyPatchCallOutput)
            {
                applyPatchCallOutput?.Invoke(ApplyPatchCallOutput!);
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
        public bool Equals(ContentVariant1Item3 other)
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
        public static bool operator ==(ContentVariant1Item3 obj1, ContentVariant1Item3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant1Item3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant1Item3 obj1, ContentVariant1Item3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant1Item3 o && Equals(o);
        }
    }
}
