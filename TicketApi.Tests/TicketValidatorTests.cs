
using TicketApi;
using Xunit;

namespace TicketApi.Tests;

public class TicketValidatorTests
{
    [Theory]
    [InlineData("Login error", false)]
    [InlineData("Bug", false)]
    [InlineData("", false)]
    [InlineData("     ", false)]
    [InlineData(null, false)]
    [InlineData("  Valid title  ", true)]
    public void IsValidTitle_ReturnsExpectedResult(
        string? title, bool expected)
    {
        bool actual = TicketValidator.IsValidTitle(title);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TitleLongerThan100Characters_IsInvalid()
    {
        string title = new string('A', 101);

        Assert.False(TicketValidator.IsValidTitle(title));
    }
}
