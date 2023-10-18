namespace ImageCompression.RunLength;

public class Decoder
{
    public byte[] RunLengthDecode(byte[] compressedImage)
    {
        var decodedImage = new List<byte>();
        var pointer = 0;

        while (pointer < compressedImage.Length)
        {
            var count = compressedImage[pointer];
            var repeatedByte = compressedImage[pointer + 1];

            decodedImage.AddRange(Enumerable.Repeat(repeatedByte, count));

            pointer += 2;
        }

        return decodedImage.ToArray();
    }
}
