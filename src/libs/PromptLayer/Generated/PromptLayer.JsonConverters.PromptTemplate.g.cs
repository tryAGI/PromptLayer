#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class PromptTemplateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.PromptTemplate>
    {
        /// <inheritdoc />
        public override global::PromptLayer.PromptTemplate Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminator>(ref readerCopy, options);

            global::PromptLayer.CompletionPrompt? completion = default;
            if (discriminator?.Type == global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType.Completion)
            {
                completion = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.CompletionPrompt>(ref reader, options);
            }
            global::PromptLayer.ChatPrompt? chat = default;
            if (discriminator?.Type == global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType.Chat)
            {
                chat = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ChatPrompt>(ref reader, options);
            }

            var __value = new global::PromptLayer.PromptTemplate(
                discriminator?.Type,
                completion,

                chat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.PromptTemplate value,
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