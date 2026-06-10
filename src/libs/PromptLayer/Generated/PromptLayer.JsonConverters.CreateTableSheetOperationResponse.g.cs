#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class CreateTableSheetOperationResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.CreateTableSheetOperationResponse>
    {
        /// <inheritdoc />
        public override global::PromptLayer.CreateTableSheetOperationResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("cell_count")) __score0++;
            if (__jsonProps.Contains("cells")) __score0++;
            if (__jsonProps.Contains("execution_id")) __score0++;
            if (__jsonProps.Contains("execution_ids")) __score0++;
            if (__jsonProps.Contains("operation")) __score0++;
            if (__jsonProps.Contains("operation_id")) __score0++;
            if (__jsonProps.Contains("status_url")) __score0++;
            if (__jsonProps.Contains("success")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            if (__jsonProps.Contains("virtual_cell_count")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cell_count")) __score1++;
            if (__jsonProps.Contains("cells")) __score1++;
            if (__jsonProps.Contains("success")) __score1++;
            if (__jsonProps.Contains("virtual_cell_count")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("affected_cell_count")) __score2++;
            if (__jsonProps.Contains("confirmation_token")) __score2++;
            if (__jsonProps.Contains("message")) __score2++;
            if (__jsonProps.Contains("requires_confirmation")) __score2++;
            if (__jsonProps.Contains("success")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::PromptLayer.CreateTableSheetOperationQueuedResponse? createTableSheetOperationQueuedResponse = default;
            global::PromptLayer.CreateTableSheetOperationNoopResponse? createTableSheetOperationNoopResponse = default;
            global::PromptLayer.CreateTableSheetOperationConfirmationResponse? createTableSheetOperationConfirmationResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationQueuedResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponse).Name}");
                        createTableSheetOperationQueuedResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationNoopResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationNoopResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationNoopResponse).Name}");
                        createTableSheetOperationNoopResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationConfirmationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationConfirmationResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationConfirmationResponse).Name}");
                        createTableSheetOperationConfirmationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createTableSheetOperationQueuedResponse == null && createTableSheetOperationNoopResponse == null && createTableSheetOperationConfirmationResponse == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationQueuedResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponse).Name}");
                    createTableSheetOperationQueuedResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (createTableSheetOperationQueuedResponse == null && createTableSheetOperationNoopResponse == null && createTableSheetOperationConfirmationResponse == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationNoopResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationNoopResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationNoopResponse).Name}");
                    createTableSheetOperationNoopResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (createTableSheetOperationQueuedResponse == null && createTableSheetOperationNoopResponse == null && createTableSheetOperationConfirmationResponse == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationConfirmationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationConfirmationResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationConfirmationResponse).Name}");
                    createTableSheetOperationConfirmationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::PromptLayer.CreateTableSheetOperationResponse(
                createTableSheetOperationQueuedResponse,

                createTableSheetOperationNoopResponse,

                createTableSheetOperationConfirmationResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.CreateTableSheetOperationResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateTableSheetOperationQueuedResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationQueuedResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateTableSheetOperationQueuedResponse!, typeInfo);
            }
            else if (value.IsCreateTableSheetOperationNoopResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationNoopResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationNoopResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationNoopResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateTableSheetOperationNoopResponse!, typeInfo);
            }
            else if (value.IsCreateTableSheetOperationConfirmationResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.CreateTableSheetOperationConfirmationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.CreateTableSheetOperationConfirmationResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.CreateTableSheetOperationConfirmationResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateTableSheetOperationConfirmationResponse!, typeInfo);
            }
        }
    }
}