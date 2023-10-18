using ImageCompression.RunLength;

namespace ImageCompression.Tests;

public class RunLengthEncoderTest
{
    [Fact]
    public void Test_RunLengthEncode()
    {
        // Arrange
        var encode = new Encoder();
        var input = new byte[] { 65, 65, 66, 66, 65, 65, 65 };

        var expected = new byte[] { 2, 65, 2, 66, 3, 65 };

        // Act
        var result = encode.RunLengthEncode(input);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expected, result);
    }
}