#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer.JsonConverters
{
    /// <inheritdoc />
    public class SearchRequestLogsRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PromptLayer.SearchRequestLogsRequest>
    {
        /// <inheritdoc />
        public override global::PromptLayer.SearchRequestLogsRequest Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("filter_group")) __score0++;
            if (__jsonProps.Contains("filter_group.filters")) __score0++;
            if (__jsonProps.Contains("filter_group.logic")) __score0++;
            if (__jsonProps.Contains("metadata_cost_breakdown_key")) __score0++;
            if (__jsonProps.Contains("q")) __score0++;
            if (__jsonProps.Contains("sort_by")) __score0++;
            if (__jsonProps.Contains("sort_order")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("include_prompt_name")) __score1++;
            if (__jsonProps.Contains("page")) __score1++;
            if (__jsonProps.Contains("per_page")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::PromptLayer.RequestLogQuery? requestLogQuery = default;
            global::PromptLayer.SearchRequestLogsRequestVariant2? searchRequestLogsRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.RequestLogQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.RequestLogQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.RequestLogQuery).Name}");
                        requestLogQuery = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.SearchRequestLogsRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.SearchRequestLogsRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.SearchRequestLogsRequestVariant2).Name}");
                        searchRequestLogsRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (requestLogQuery == null && searchRequestLogsRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.RequestLogQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.RequestLogQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.RequestLogQuery).Name}");
                    requestLogQuery = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (requestLogQuery == null && searchRequestLogsRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.SearchRequestLogsRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.SearchRequestLogsRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.SearchRequestLogsRequestVariant2).Name}");
                    searchRequestLogsRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::PromptLayer.SearchRequestLogsRequest(
                requestLogQuery,

                searchRequestLogsRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PromptLayer.SearchRequestLogsRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRequestLogQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.RequestLogQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.RequestLogQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.RequestLogQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequestLogQuery!, typeInfo);
            }
            else if (value.IsSearchRequestLogsRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PromptLayer.SearchRequestLogsRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PromptLayer.SearchRequestLogsRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PromptLayer.SearchRequestLogsRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchRequestLogsRequestVariant2!, typeInfo);
            }
        }
    }
}