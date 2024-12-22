using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Enums.DeployEnvironment.Tests;

[Collection("Collection")]
public class DeployEnvironmentTests : FixturedUnitTest
{
    public DeployEnvironmentTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
