#!/bin/bash
set -e

echo "📂 current dir: $(pwd)"

# Generar el .env local desde el template si todavía no existe.
if [ ! -f TransbankSdkDotnetExample/.env ]; then
    cp TransbankSdkDotnetExample/.env.example TransbankSdkDotnetExample/.env
fi

# Estado del proyecto: restaurar dependencias .NET de la solución.
# Nota: card.js (wwwroot/lib/card/) está versionado en el repo, no se restaura acá.
dotnet restore

# Confiar en el certificado HTTPS de desarrollo de ASP.NET Core.
dotnet dev-certs https --trust || echo "⚠️  Warning: Failed to trust HTTPS dev certificate. You may see browser warnings (note: --trust is not fully supported on Linux)."
