using ImageCompression.RunLength;

namespace ImageCompression.Decompressor;

public class Decompressor
{
    public byte[] DecompressImage(byte[] compressedImage)
    {
        var decoder = new Decoder();
        var decompressedImage = decoder.RunLengthDecode(compressedImage);

        return decompressedImage;
    }
}
