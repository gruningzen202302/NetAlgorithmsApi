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
        var expressionResponsePayload = new ExpressionResponsePayload(false, "a does not match the entire string aa.");
        Assert.False(expressionResponsePayload.Match);
        Assert.Equal("a does not match the entire string aa.", expressionResponsePayload.Explanation);
    }
}

public record ExpressionResponsePayload(bool Match, string Explanation);