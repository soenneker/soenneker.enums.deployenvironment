using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.DeployEnvironment;

/// <summary>
/// Identifies the isolated runtime environment in which an application or workload is deployed.
/// </summary>
[EnumValue<string>]
public sealed partial class DeployEnvironment
{
    /// <summary>
    /// Unit and integration test execution, including pull-request validation.
    /// </summary>
    public static readonly DeployEnvironment Test = new(nameof(Test));

    /// <summary>
    /// Developer workstations and local application execution using the base application settings.
    /// </summary>
    public static readonly DeployEnvironment Local = new(nameof(Local));

    /// <summary>
    /// End-to-end test environment used for automated full-system validation with deterministic data,
    /// isolated configuration, and safe or mocked external providers.
    /// </summary>
    public static readonly DeployEnvironment E2E = new(nameof(E2E));

    /// <summary>
    /// Shared development deployment using development-specific application settings.
    /// </summary>
    public static readonly DeployEnvironment Development = new(nameof(Development));

    /// <summary>
    /// Pre-production staging deployment using staging-specific application settings.
    /// </summary>
    public static readonly DeployEnvironment Staging = new(nameof(Staging));

    /// <summary>
    /// Live production deployment using production-specific application settings.
    /// </summary>
    public static readonly DeployEnvironment Production = new(nameof(Production));
}
