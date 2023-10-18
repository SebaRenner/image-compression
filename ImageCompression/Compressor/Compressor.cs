using ImageCompression.RunLength;

namespace ImageCompression.Compressor;

public class Compressor
{   
    public CompressedImage CompressImage(string imagePath)
    {
        var imageReader = new ImageCompression.ImageReader.ImageReader();
        var imageBytes = imageReader.ReadImageBytes(imagePath);

        var encoder = new Encoder();
        var compressedImage = encoder.RunLengthEncode(imageBytes);

        return new(compressedImage, imageBytes);
    }
}
