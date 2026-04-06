#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class MessagesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.MessagesItem>
    {
        /// <inheritdoc />
        public override global::PromptLayer.MessagesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ChatPromptMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ChatPromptMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ChatPromptMessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::PromptLayer.SystemMessage? system = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.SystemMessage)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.UserMessage? user = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.UserMessage)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.AssistantMessage? assistant = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.AssistantMessage)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.FunctionMessage? function = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.FunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.FunctionMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.FunctionMessage)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ToolMessage? tool = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ToolMessage)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.PlaceholderMessage? placeholder = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Placeholder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.PlaceholderMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.PlaceholderMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.PlaceholderMessage)}");
                placeholder = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.DeveloperMessage? developer = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Developer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.DeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.DeveloperMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.DeveloperMessage)}");
                developer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::PromptLayer.MessagesItem(
                discriminator?.Role,
                system,

                user,

                assistant,

                function,

                tool,

                placeholder,

                developer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.MessagesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System!, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User!, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant!, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.FunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.FunctionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.FunctionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool!, typeInfo);
            }
            else if (value.IsPlaceholder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.PlaceholderMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.PlaceholderMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.PlaceholderMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Placeholder!, typeInfo);
            }
            else if (value.IsDeveloper)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.DeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.DeveloperMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.DeveloperMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Developer!, typeInfo);
            }
        }
    }
}