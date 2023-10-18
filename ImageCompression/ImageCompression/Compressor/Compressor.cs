using ImageCompression.RunLength;

namespace ImageCompression.Compressor;

public class Compressor
{   
    public string CompressImage(string imagePath)
    {
        var imageReader = new ImageCompression.ImageReader.ImageReader();
        var imageBytes = imageReader.ReadImageBytes(imagePath);

        var encoder = new RunLengthEncoder();
        var compressedImage = encoder.RunLengthEncode(imageBytes);

        return compressedImage;
    }
}
