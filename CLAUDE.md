# CLAUDE.md -- PromptLayer SDK

## Overview

Auto-generated C# SDK for [PromptLayer](https://promptlayer.com/) -- prompt management, versioning, A/B testing, and LLM request tracking platform.
OpenAPI spec from the official [MagnivOrg/prompt-layer-docs](https://github.com/MagnivOrg/prompt-layer-docs) repo.

## Build & Test

```bash
dotnet build PromptLayer.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth (sent as `X-API-KEY` header via `--security-scheme`):

```csharp
var client = new PromptLayerClient(apiKey); // PROMPTLAYER_API_KEY env var
```

## Key Files

- `src/libs/PromptLayer/openapi.json` -- OpenAPI spec (downloaded from MagnivOrg/prompt-layer-docs)
- `src/libs/PromptLayer/generate.sh` -- Downloads spec, removes per-operation X-API-KEY params, runs autosdk with `--security-scheme ApiKey:Header:X-API-KEY`
- `src/libs/PromptLayer/Generated/` -- **Never edit** -- auto-generated code (~1293 files)
- `src/libs/PromptLayer/Extensions/PromptLayerClient.AsTool.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- OpenAPI 3.1.0 spec from official PromptLayer docs repo
- `generate.sh` removes `X-API-KEY` per-operation header parameters (every endpoint had it as both a `securitySchemes` entry and a required parameter -- removing duplicates prevents auth being a method argument)
- `generate.sh` adds missing `servers` section (`https://api.promptlayer.com`)
- `generate.sh` fixes `info.title` from generic "FastAPI" to "PromptLayer API"
- Auth: `--security-scheme ApiKey:Header:X-API-KEY` sends the key directly as the native header (no Bearer conversion or PrepareRequest hook needed)

## Sub-client Pattern

PromptLayer API has tagged operations generating sub-clients:
- `client.PromptTemplates.*` -- List, get, publish, patch, label prompt templates
- `client.Prompts.*` -- Create prompt labels
- `client.Rest.*` -- Publish/patch templates, track metadata/group/prompt/score
- `client.Tracking.*` -- Search request logs, get request details, get traces
- `client.Datasets.*` -- List datasets, get rows, create dataset groups/versions
- `client.Evaluations.*` -- List evaluations, get evaluation rows
- `client.Reports.*` -- Create/get/run/delete reports, add report columns, get report scores
- `client.Workflow.*` -- List/get/create/patch/run workflows, get labels, get execution results
- `client.Folders.*` -- Create/update folders, list/move/delete folder entities
- `client.Spans.*` -- Create spans in bulk
- `client.Otlp.*` -- Ingest OTLP traces
- `client.Request.*` -- Log requests
- `client.Group.*` -- Track groups
- `client.Metadata.*` -- Track metadata
- `client.Prompt.*` -- Track prompts
- `client.Score.*` -- Track scores

## MEAI

AIFunction tools implemented for use with any `IChatClient`:
- `AsListPromptsTool()` -- List prompt templates with pagination and name filtering
- `AsGetPromptTool()` -- Get a specific prompt template by name/ID with optional version/label
- `AsSearchRequestsTool()` -- Search tracked LLM request logs with text query
- `AsListWorkflowsTool()` -- List available workflows with version info
