#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.ContentVariant1Item>
    {
        /// <inheritdoc />
        public override global::PromptLayer.ContentVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::PromptLayer.TextContent? text = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ThinkingContent? thinking = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ThinkingContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ThinkingContent)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.CodeContent? code = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CodeContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CodeContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.CodeContent)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ImageContent? imageUrl = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ImageContent)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.MediaContent? media = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.Media)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.MediaContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.MediaContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.MediaContent)}");
                media = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.MediaVariable? mediaVariable = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.MediaVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.MediaVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.MediaVariable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.MediaVariable)}");
                mediaVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.OutputMediaContent? outputMedia = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.OutputMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.OutputMediaContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.OutputMediaContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.OutputMediaContent)}");
                outputMedia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ServerToolUseContent? serverToolUse = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.ServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ServerToolUseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ServerToolUseContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ServerToolUseContent)}");
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.WebSearchToolResultContent? webSearchToolResult = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.WebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.WebSearchToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.WebSearchToolResultContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.WebSearchToolResultContent)}");
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.CodeExecutionResultContent? codeExecutionResult = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.CodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CodeExecutionResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CodeExecutionResultContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.CodeExecutionResultContent)}");
                codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.McpListToolsContent? mcpListTools = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.McpListTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.McpListToolsContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.McpListToolsContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.McpListToolsContent)}");
                mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.McpCallContent? mcpCall = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.McpCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.McpCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.McpCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.McpCallContent)}");
                mcpCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.McpApprovalRequestContent? mcpApprovalRequest = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.McpApprovalRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.McpApprovalRequestContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.McpApprovalRequestContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.McpApprovalRequestContent)}");
                mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.McpApprovalResponseContent? mcpApprovalResponse = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.McpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.McpApprovalResponseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.McpApprovalResponseContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.McpApprovalResponseContent)}");
                mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.BashCodeExecutionToolResultContent? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.BashCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.BashCodeExecutionToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.BashCodeExecutionToolResultContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.BashCodeExecutionToolResultContent)}");
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.TextEditorCodeExecutionToolResultContent? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.TextEditorCodeExecutionToolResultContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.TextEditorCodeExecutionToolResultContent)}");
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ShellCallContent? shellCall = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.ShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ShellCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ShellCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ShellCallContent)}");
                shellCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ShellCallOutputContent? shellCallOutput = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.ShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ShellCallOutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ShellCallOutputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ShellCallOutputContent)}");
                shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ApplyPatchCallContent? applyPatchCall = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.ApplyPatchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ApplyPatchCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ApplyPatchCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ApplyPatchCallContent)}");
                applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ApplyPatchCallOutputContent? applyPatchCallOutput = default;
            if (discriminator?.Type == global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType.ApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ApplyPatchCallOutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ApplyPatchCallOutputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ApplyPatchCallOutputContent)}");
                applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::PromptLayer.ContentVariant1Item(
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
            global::PromptLayer.ContentVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ThinkingContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ThinkingContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CodeContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CodeContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CodeContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ImageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ImageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl!, typeInfo);
            }
            else if (value.IsMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.MediaContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.MediaContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.MediaContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Media!, typeInfo);
            }
            else if (value.IsMediaVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.MediaVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.MediaVariable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.MediaVariable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MediaVariable!, typeInfo);
            }
            else if (value.IsOutputMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.OutputMediaContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.OutputMediaContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.OutputMediaContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMedia!, typeInfo);
            }
            else if (value.IsServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ServerToolUseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ServerToolUseContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ServerToolUseContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse!, typeInfo);
            }
            else if (value.IsWebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.WebSearchToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.WebSearchToolResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.WebSearchToolResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult!, typeInfo);
            }
            else if (value.IsCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CodeExecutionResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CodeExecutionResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CodeExecutionResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionResult!, typeInfo);
            }
            else if (value.IsMcpListTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.McpListToolsContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.McpListToolsContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.McpListToolsContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools!, typeInfo);
            }
            else if (value.IsMcpCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.McpCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.McpCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.McpCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall!, typeInfo);
            }
            else if (value.IsMcpApprovalRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.McpApprovalRequestContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.McpApprovalRequestContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.McpApprovalRequestContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest!, typeInfo);
            }
            else if (value.IsMcpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.McpApprovalResponseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.McpApprovalResponseContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.McpApprovalResponseContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse!, typeInfo);
            }
            else if (value.IsBashCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.BashCodeExecutionToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.BashCodeExecutionToolResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.BashCodeExecutionToolResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult!, typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.TextEditorCodeExecutionToolResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult!, typeInfo);
            }
            else if (value.IsShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ShellCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ShellCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ShellCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCall!, typeInfo);
            }
            else if (value.IsShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ShellCallOutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ShellCallOutputContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ShellCallOutputContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutput!, typeInfo);
            }
            else if (value.IsApplyPatchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ApplyPatchCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ApplyPatchCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ApplyPatchCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCall!, typeInfo);
            }
            else if (value.IsApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ApplyPatchCallOutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ApplyPatchCallOutputContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ApplyPatchCallOutputContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutput!, typeInfo);
            }
        }
    }
}