
#nullable enable

namespace PromptLayer
{
    public sealed partial class PromptLayerClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::PromptLayer.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-API-KEY",
                Value = apiKey,
            });
        }
    }
}