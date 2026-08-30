[![](https://img.shields.io/nuget/v/Soenneker.Enums.DeployEnvironment.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.DeployEnvironment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.deployenvironment/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.deployenvironment/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Enums.DeployEnvironment.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.DeployEnvironment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.deployenvironment/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.deployenvironment/actions/workflows/codeql.yml)

# Soenneker.Enums.DeployEnvironment

A string-backed enum-value type for carrying a deployment-environment identifier through application and API contracts.

## Install

```bash
dotnet add package Soenneker.Enums.DeployEnvironment
```

## Usage

```csharp
using Soenneker.Enums.DeployEnvironment;

DeployEnvironment environment = DeployEnvironment.Staging;
string wireValue = environment.Value; // "Staging"

if (DeployEnvironment.TryFromValue(configuredValue, out DeployEnvironment? parsed))
{
    environment = parsed;
}
```

Available values:

- `Test` — unit, integration, or pull-request validation
- `Local` — a developer workstation
- `E2E` — isolated end-to-end validation
- `Development` — a shared development deployment
- `Staging` — pre-production validation
- `Production` — the live deployment

`System.Text.Json` serializes the type as the shown string value. `FromValue` throws for an unknown value; use `TryFromValue` when reading configuration or requests. `FromName` and `TryFromName` are also generated.

This type does not read `ASPNETCORE_ENVIRONMENT` or `DOTNET_ENVIRONMENT`, change application configuration, or integrate with `IHostEnvironment` automatically. Map those values explicitly and decide how unknown environments should be handled. Do not use an environment label as an authorization boundary or as the sole control protecting destructive operations.
