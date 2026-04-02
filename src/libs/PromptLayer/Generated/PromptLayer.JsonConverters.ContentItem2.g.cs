#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class ContentItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.ContentItem2>
    {
        /// <inheritdoc />
        public override global::PromptLayer.ContentItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.SystemMessageContentItemDiscriminator>(ref readerCopy, options);

            global::PromptLayer.TextContent? text = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.TextContent>(ref reader, options);
            }
            global::PromptLayer.ThinkingContent? thinking = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ThinkingContent>(ref reader, options);
            }
            global::PromptLayer.CodeContent? code = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.CodeContent>(ref reader, options);
            }
            global::PromptLayer.ImageContent? imageUrl = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ImageContent>(ref reader, options);
            }
            global::PromptLayer.MediaContent? media = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.Media)
            {
                media = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.MediaContent>(ref reader, options);
            }
            global::PromptLayer.MediaVariable? mediaVariable = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.MediaVariable)
            {
                mediaVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.MediaVariable>(ref reader, options);
            }
            global::PromptLayer.OutputMediaContent? outputMedia = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.OutputMedia)
            {
                outputMedia = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.OutputMediaContent>(ref reader, options);
            }
            global::PromptLayer.ServerToolUseContent? serverToolUse = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.ServerToolUse)
            {
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ServerToolUseContent>(ref reader, options);
            }
            global::PromptLayer.WebSearchToolResultContent? webSearchToolResult = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.WebSearchToolResult)
            {
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.WebSearchToolResultContent>(ref reader, options);
            }
            global::PromptLayer.CodeExecutionResultContent? codeExecutionResult = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.CodeExecutionResult)
            {
                codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.CodeExecutionResultContent>(ref reader, options);
            }
            global::PromptLayer.McpListToolsContent? mcpListTools = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.McpListTools)
            {
                mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.McpListToolsContent>(ref reader, options);
            }
            global::PromptLayer.McpCallContent? mcpCall = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.McpCall)
            {
                mcpCall = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.McpCallContent>(ref reader, options);
            }
            global::PromptLayer.McpApprovalRequestContent? mcpApprovalRequest = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.McpApprovalRequest)
            {
                mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.McpApprovalRequestContent>(ref reader, options);
            }
            global::PromptLayer.McpApprovalResponseContent? mcpApprovalResponse = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.McpApprovalResponse)
            {
                mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.McpApprovalResponseContent>(ref reader, options);
            }
            global::PromptLayer.BashCodeExecutionToolResultContent? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.BashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.BashCodeExecutionToolResultContent>(ref reader, options);
            }
            global::PromptLayer.TextEditorCodeExecutionToolResultContent? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.TextEditorCodeExecutionToolResultContent>(ref reader, options);
            }
            global::PromptLayer.ShellCallContent? shellCall = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.ShellCall)
            {
                shellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ShellCallContent>(ref reader, options);
            }
            global::PromptLayer.ShellCallOutputContent? shellCallOutput = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.ShellCallOutput)
            {
                shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ShellCallOutputContent>(ref reader, options);
            }
            global::PromptLayer.ApplyPatchCallContent? applyPatchCall = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.ApplyPatchCall)
            {
                applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ApplyPatchCallContent>(ref reader, options);
            }
            global::PromptLayer.ApplyPatchCallOutputContent? applyPatchCallOutput = default;
            if (discriminator?.Type == global::PromptLayer.SystemMessageContentItemDiscriminatorType.ApplyPatchCallOutput)
            {
                applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ApplyPatchCallOutputContent>(ref reader, options);
            }

            var __value = new global::PromptLayer.ContentItem2(
                discriminator?.Type,
                text,

                thinking,

                code,

                imageUrl,

                media,

                mediaVariable,

                outputMedia,

                serverToolUse,

                webSearchToolResult,

                codeExecutionResult,

                mcpListTools,

                mcpCall,

                mcpApprovalRequest,

                mcpApprovalResponse,

                bashCodeExecutionToolResult,

                textEditorCodeExecutionToolResult,

                shellCall,

                shellCallOutput,

                applyPatchCall,

                applyPatchCallOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.ContentItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::PromptLayer.TextContent), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::PromptLayer.ThinkingContent), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::PromptLayer.CodeContent), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::PromptLayer.ImageContent), options);
            }
            else if (value.IsMedia)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Media, typeof(global::PromptLayer.MediaContent), options);
            }
            else if (value.IsMediaVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MediaVariable, typeof(global::PromptLayer.MediaVariable), options);
            }
            else if (value.IsOutputMedia)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMedia, typeof(global::PromptLayer.OutputMediaContent), options);
            }
            else if (value.IsServerToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse, typeof(global::PromptLayer.ServerToolUseContent), options);
            }
            else if (value.IsWebSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult, typeof(global::PromptLayer.WebSearchToolResultContent), options);
            }
            else if (value.IsCodeExecutionResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionResult, typeof(global::PromptLayer.CodeExecutionResultContent), options);
            }
            else if (value.IsMcpListTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools, typeof(global::PromptLayer.McpListToolsContent), options);
            }
            else if (value.IsMcpCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall, typeof(global::PromptLayer.McpCallContent), options);
            }
            else if (value.IsMcpApprovalRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest, typeof(global::PromptLayer.McpApprovalRequestContent), options);
            }
            else if (value.IsMcpApprovalResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse, typeof(global::PromptLayer.McpApprovalResponseContent), options);
            }
            else if (value.IsBashCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult, typeof(global::PromptLayer.BashCodeExecutionToolResultContent), options);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult, typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContent), options);
            }
            else if (value.IsShellCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCall, typeof(global::PromptLayer.ShellCallContent), options);
            }
            else if (value.IsShellCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutput, typeof(global::PromptLayer.ShellCallOutputContent), options);
            }
            else if (value.IsApplyPatchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCall, typeof(global::PromptLayer.ApplyPatchCallContent), options);
            }
            else if (value.IsApplyPatchCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutput, typeof(global::PromptLayer.ApplyPatchCallOutputContent), options);
            }
        }
    }
}