#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class PromptTemplate6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.PromptTemplate6>
    {
        /// <inheritdoc />
        public override global::PromptLayer.PromptTemplate6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::PromptLayer.CompletionPrompt? completion = default;
            if (discriminator?.Type == global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminatorType.Completion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CompletionPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CompletionPrompt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.CompletionPrompt)}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::PromptLayer.ChatPrompt? chat = default;
            if (discriminator?.Type == global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminatorType.Chat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ChatPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ChatPrompt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::PromptLayer.ChatPrompt)}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::PromptLayer.PromptTemplate6(
                discriminator?.Type,
                completion,

                chat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.PromptTemplate6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CompletionPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CompletionPrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CompletionPrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion!, typeInfo);
            }
            else if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.ChatPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.ChatPrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.ChatPrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat!, typeInfo);
            }
        }
    }
}