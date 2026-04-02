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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ChatPromptMessageDiscriminator>(ref readerCopy, options);

            global::PromptLayer.SystemMessage? system = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.System)
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.SystemMessage>(ref reader, options);
            }
            global::PromptLayer.UserMessage? user = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.User)
            {
                user = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.UserMessage>(ref reader, options);
            }
            global::PromptLayer.AssistantMessage? assistant = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Assistant)
            {
                assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.AssistantMessage>(ref reader, options);
            }
            global::PromptLayer.FunctionMessage? function = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.FunctionMessage>(ref reader, options);
            }
            global::PromptLayer.ToolMessage? tool = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ToolMessage>(ref reader, options);
            }
            global::PromptLayer.PlaceholderMessage? placeholder = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Placeholder)
            {
                placeholder = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.PlaceholderMessage>(ref reader, options);
            }
            global::PromptLayer.DeveloperMessage? developer = default;
            if (discriminator?.Role == global::PromptLayer.ChatPromptMessageDiscriminatorRole.Developer)
            {
                developer = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.DeveloperMessage>(ref reader, options);
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

            if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::PromptLayer.SystemMessage), options);
            }
            else if (value.IsUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeof(global::PromptLayer.UserMessage), options);
            }
            else if (value.IsAssistant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeof(global::PromptLayer.AssistantMessage), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::PromptLayer.FunctionMessage), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::PromptLayer.ToolMessage), options);
            }
            else if (value.IsPlaceholder)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Placeholder, typeof(global::PromptLayer.PlaceholderMessage), options);
            }
            else if (value.IsDeveloper)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Developer, typeof(global::PromptLayer.DeveloperMessage), options);
            }
        }
    }
}