# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The PromptLayer SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to PromptLayer's prompt management, versioning, request tracking, and workflow capabilities.

## Installation

```bash
dotnet add package PromptLayer
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListPromptsTool()` | `ListPromptTemplates` | Lists available prompt templates with pagination and name filtering |
| `AsGetPromptTool()` | `GetPromptTemplate` | Retrieves a specific prompt template by name or ID, with optional version/label |
| `AsSearchRequestsTool()` | `SearchRequestLogs` | Searches tracked LLM request logs with text query |
| `AsListWorkflowsTool()` | `ListWorkflows` | Lists available workflows with version and release label info |

## Usage

```csharp
using Microsoft.Extensions.AI;
using PromptLayer;

// Create the PromptLayer client
var promptLayer = new PromptLayerClient(
    apiKey: Environment.GetEnvironmentVariable("PROMPTLAYER_API_KEY")!);

// Create tools
var tools = new AIFunction[]
{
    promptLayer.AsListPromptsTool(),
    promptLayer.AsGetPromptTool(),
    promptLayer.AsSearchRequestsTool(),
    promptLayer.AsListWorkflowsTool(),
};

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = tools,
};

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List all my prompt templates and show me the details of the latest one."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

### ListPromptTemplates

Lists available prompt templates in PromptLayer. Optionally filter by name. Returns template IDs, names, versions, and commit messages.

```csharp
var tool = client.AsListPromptsTool(perPage: 20);
```

**Parameters:**

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `perPage` | `int` | `20` | Maximum number of templates to return per page |

**Function parameters (passed by the AI model):**

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `page` | `int?` | No | Page number (defaults to 1) |
| `name` | `string?` | No | Filter templates by name |

### GetPromptTemplate

Retrieves a specific prompt template from PromptLayer by its name or ID. Optionally specify a version number or label. Returns the template content, metadata, and version info.

```csharp
var tool = client.AsGetPromptTool();
```

**Function parameters (passed by the AI model):**

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `identifier` | `string` | Yes | Template name or ID |
| `version` | `int?` | No | Specific version number |
| `label` | `string?` | No | Release label (e.g., "production", "staging") |

### SearchRequestLogs

Searches tracked LLM request logs in PromptLayer. Optionally filter by a text query. Returns paginated request log entries including inputs, outputs, and metadata.

```csharp
var tool = client.AsSearchRequestsTool(perPage: 20);
```

**Parameters:**

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `perPage` | `int` | `20` | Maximum number of results to return per page |

**Function parameters (passed by the AI model):**

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `query` | `string?` | No | Text query to filter request logs |
| `page` | `int?` | No | Page number (defaults to 1) |

### ListWorkflows

Lists available workflows in PromptLayer. Returns workflow IDs, names, latest version numbers, and release labels.

```csharp
var tool = client.AsListWorkflowsTool(perPage: 20);
```

**Parameters:**

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `perPage` | `int` | `20` | Maximum number of workflows to return per page |

**Function parameters (passed by the AI model):**

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `page` | `int?` | No | Page number (defaults to 1) |

## Dependency Injection

You can register the PromptLayer client and tools with `Microsoft.Extensions.DependencyInjection`:

```csharp
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.AI;
using PromptLayer;

var services = new ServiceCollection();

// Register the PromptLayer client
services.AddSingleton(_ => new PromptLayerClient(
    apiKey: Environment.GetEnvironmentVariable("PROMPTLAYER_API_KEY")!));

// Register tools as AIFunction instances
services.AddSingleton(sp =>
{
    var client = sp.GetRequiredService<PromptLayerClient>();
    return new List<AIFunction>
    {
        client.AsListPromptsTool(),
        client.AsGetPromptTool(),
        client.AsSearchRequestsTool(),
        client.AsListWorkflowsTool(),
    };
});
```

## Selective Tool Registration

You don't need to register all tools. Pick only what your agent needs:

```csharp
// Prompt management agent — only needs prompt tools
var options = new ChatOptions
{
    Tools =
    [
        promptLayer.AsListPromptsTool(),
        promptLayer.AsGetPromptTool(),
    ],
};

// Observability agent — only needs request log search
var options = new ChatOptions
{
    Tools =
    [
        promptLayer.AsSearchRequestsTool(perPage: 50),
    ],
};
```
