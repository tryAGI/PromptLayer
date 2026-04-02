#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class OutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.Output>
    {
        /// <inheritdoc />
        public override global::PromptLayer.Output Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.LogRequestOutputDiscriminator>(ref readerCopy, options);

            global::PromptLayer.CompletionPrompt? completion = default;
            if (discriminator?.Type == global::PromptLayer.LogRequestOutputDiscriminatorType.Completion)
            {
                completion = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.CompletionPrompt>(ref reader, options);
            }
            global::PromptLayer.ChatPrompt? chat = default;
            if (discriminator?.Type == global::PromptLayer.LogRequestOutputDiscriminatorType.Chat)
            {
                chat = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ChatPrompt>(ref reader, options);
            }

            var __value = new global::PromptLayer.Output(
                discriminator?.Type,
                completion,

                chat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.Output value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCompletion)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeof(global::PromptLayer.CompletionPrompt), options);
            }
            else if (value.IsChat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeof(global::PromptLayer.ChatPrompt), options);
            }
        }
    }
}