[![](https://img.shields.io/nuget/v/Soenneker.Enums.DeployEnvironment.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.DeployEnvironment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.deployenvironment/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.deployenvironment/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Enums.DeployEnvironment.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.DeployEnvironment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.deployenvironment/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.deployenvironment/actions/workflows/codeql.yml)

# Soenneker.Enums.DeployEnvironment

Identifies the isolated runtime environment in which an application or workload is deployed.

## Install

```bash
dotnet add package Soenneker.Enums.DeployEnvironment
```

## What you get

- `DeployEnvironment` — Identifies the isolated runtime environment in which an application or workload is deployed.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DeployEnvironment.Test` | Unit and integration test execution, including pull-request validation. | Unit and integration test execution, including pull-request validation. |
| `DeployEnvironment.Local` | Developer workstations and local application execution using the base application settings. | Developer workstations and local application execution using the base application settings. |
| `DeployEnvironment.E2E` | End-to-end test environment used for automated full-system validation with deterministic data, isolated configuration, and safe or mocked external providers. | End-to-end test environment used for automated full-system validation with deterministic data, isolated configuration, and safe or mocked external providers. |
| `DeployEnvironment.Development` | Shared development deployment using development-specific application settings. | Shared development deployment using development-specific application settings. |
| `DeployEnvironment.Staging` | Pre-production staging deployment using staging-specific application settings. | Pre-production staging deployment using staging-specific application settings. |
| `DeployEnvironment.Production` | Live production deployment using production-specific application settings. | Live production deployment using production-specific application settings. |
