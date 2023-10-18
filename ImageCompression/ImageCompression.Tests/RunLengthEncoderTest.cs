using ImageCompression.RunLength;

namespace ImageCompression.Tests;

public class RunLengthEncoderTest
{
    [Fact]
    public void Test_RunLengthEncode()
    {
        // Arrange
        var encode = new RunLengthEncoder();
        var input = new byte[] { 0, 0, 1, 0, 0, 0 };

        var expected = "20130";

        // Act
        var result = encode.RunLengthEncode(input);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expected, result);
    }
}