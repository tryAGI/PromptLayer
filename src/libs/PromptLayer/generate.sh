#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/MagnivOrg/prompt-layer-docs/master/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.json https://raw.githubusercontent.com/MagnivOrg/prompt-layer-docs/master/openapi.json

# Fix spec issues:
# 1. Set proper title
# 2. Add servers section (base URL missing from spec)
# 3. Remove X-API-KEY from per-operation parameters (auth handled by --security-scheme flag)
jq '
  .info.title = "PromptLayer API" |
  .servers = [{"url": "https://api.promptlayer.com"}] |
  # Remove X-API-KEY parameter from all operations
  (.paths[][] | objects | select(.parameters) | .parameters) |= [.[] | select(.name != "X-API-KEY")]
' openapi.json > tmp.json && mv tmp.json openapi.json

autosdk generate openapi.json \
  --namespace PromptLayer \
  --clientClassName PromptLayerClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-KEY \
  --auth-env-var PROMPTLAYER_API_KEY
