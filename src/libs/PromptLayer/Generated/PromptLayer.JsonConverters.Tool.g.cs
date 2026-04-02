#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.Tool>
    {
        /// <inheritdoc />
        public override global::PromptLayer.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.ToolDiscriminator>(ref readerCopy, options);

            global::PromptLayer.FunctionTool? function = default;
            if (discriminator?.Type == global::PromptLayer.ToolDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.FunctionTool>(ref reader, options);
            }
            global::PromptLayer.BuiltInTool? webSearch = default;
            if (discriminator?.Type == global::PromptLayer.ToolDiscriminatorType.WebSearch)
            {
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::PromptLayer.BuiltInTool>(ref reader, options);
            }

            var __value = new global::PromptLayer.Tool(
                discriminator?.Type,
                function,

                webSearch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::PromptLayer.FunctionTool), options);
            }
            else if (value.IsWebSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeof(global::PromptLayer.BuiltInTool), options);
            }
        }
    }
}