using Intellenum;

namespace Soenneker.Enums.DeployEnvironment;

[Intellenum<string>]
public sealed partial class DeployEnvironment
{
    /// <summary>
    /// PR and Local Unit and Integration Tests
    /// </summary>
    public static readonly DeployEnvironment Test = new(nameof(Test));

    /// <summary>
    /// Developer local machine, pull request pipelines. <para/>
    /// This coordinates with appsettings.json
    /// </summary>
    public static readonly DeployEnvironment Local = new(nameof(Local));

    /// <summary>
    /// Azure Development <para/>
    /// This coordinates with appsettings.Development.json
    /// </summary>
    public static readonly DeployEnvironment Development = new(nameof(Development));

    /// <summary>
    /// Azure Staging <para/>
    /// This coordinates with appsettings.Staging.json
    /// </summary>
    public static readonly DeployEnvironment Staging = new(nameof(Staging));

    /// <summary>
    /// Azure Production <para/>
    /// This coordinates with appsettings.Production.json
    /// </summary>
    public static readonly DeployEnvironment Production = new(nameof(Production));
}