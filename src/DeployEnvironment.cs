using Soenneker.SmartEnum.Named;

namespace Soenneker.Enums.DeployEnvironment;

public sealed class DeployEnvironment : NamedSmartEnum<DeployEnvironment>
{
    /// <summary>
    /// PR and Local Unit and Integration Tests
    /// </summary>
    public static readonly DeployEnvironment Test = new(nameof(Test), 0);

    /// <summary>
    /// Developer local machine, pull request pipelines. <para/>
    /// This coordinates with appsettings.json
    /// </summary>
    public static readonly DeployEnvironment Local = new(nameof(Local), 1);

    /// <summary>
    /// Azure Development <para/>
    /// This coordinates with appsettings.Development.json
    /// </summary>
    public static readonly DeployEnvironment Development = new(nameof(Development), 2);

    /// <summary>
    /// Azure Staging <para/>
    /// This coordinates with appsettings.Staging.json
    /// </summary>
    public static readonly DeployEnvironment Staging = new(nameof(Staging), 3);

    /// <summary>
    /// Azure Production <para/>
    /// This coordinates with appsettings.Production.json
    /// </summary>
    public static readonly DeployEnvironment Production = new(nameof(Production), 4);

    private DeployEnvironment(string name, int value) : base(name, value)
    {
    }
}