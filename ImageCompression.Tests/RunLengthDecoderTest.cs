using ImageCompression.RunLength;

namespace ImageCompression.Tests;

public class RunLengthDecoderTest
{
    [Fact]
    public void Test_RunLengthDecode()
    {
        // Arrange
        var encode = new Decoder();
        var input = new byte[] { 2, 65, 2, 66, 3, 65 };
        
        var expected = new byte[] { 65, 65, 66, 66, 65, 65, 65 };

        // Act
        var result = encode.RunLengthDecode(input);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expected, result);
    }
}
