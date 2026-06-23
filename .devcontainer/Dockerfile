FROM mcr.microsoft.com/devcontainers/dotnet:2.1.2-9.0-bookworm

USER root

RUN apt-get update \
    && apt-get install -y --no-install-recommends ripgrep \
    && rm -rf /var/lib/apt/lists/*

USER vscode
