using NetAlgorithmsApi;
using Xunit;
namespace NetAlgorithmsApi.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var expressionMatchRequest = new ExpressionMatchRequest("aa", "a");

        // Act
        // Call the method under test here

        // Assert
        var expressionMatchResponsePayload = new ExpressionMatchResponsePayload(
            false,
            "a does not match aa."
            );
        Assert.False(expressionMatchResponsePayload.Match);
        Assert.Equal("a does not match aa.", expressionMatchResponsePayload.Explanation);
    }
}
