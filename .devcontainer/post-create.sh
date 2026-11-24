#!/bin/bash
set -e

echo "📂 current dir: $(pwd)"

if [[ ! -f TransbankSdkDotnetExample/.env ]]; then
    cp TransbankSdkDotnetExample/.env.example TransbankSdkDotnetExample/.env
fi

sudo chown "$(id -u):$(id -g)" \
    TransbankSdkDotnetExample/bin \
    TransbankSdkDotnetExample/obj \
    Tests/bin \
    Tests/obj

dotnet restore

dotnet dev-certs https --trust || echo "⚠️  Warning: Failed to trust HTTPS dev certificate. You may see browser warnings (note: --trust is not fully supported on Linux)."
