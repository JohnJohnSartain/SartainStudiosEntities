using SartainStudios.Entities.Entities;
using Xunit;

namespace CommonTests;

public class RoleTests
{
    [Fact] public void AccessingRoleProducesExpectedResult_God() => Assert.Equal("god", Role.God);
    [Fact] public void AccessingRoleProducesExpectedResult_Service() => Assert.Equal("service", Role.Service);
    [Fact] public void AccessingRoleProducesExpectedResult_Administrator() => Assert.Equal("administrator", Role.Administrator);
    [Fact] public void AccessingRoleProducesExpectedResult_User() => Assert.Equal("user", Role.User);
}