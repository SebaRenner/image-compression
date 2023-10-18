using ImageCompression.Compressor;
using ImageCompression.Decompressor;

Console.WriteLine("input path to image");
var input = string.Empty;

while (input.Length < 5 || !input.EndsWith(".png"))
{
    input = Console.ReadLine();

    if (input.Length < 5 || !input.EndsWith(".png"))
    {
        Console.WriteLine("file path has to be longer than 5 charcters and has to be a png");
    }
}

var compressor = new Compressor();
var compressedImage = compressor.CompressImage(input);

var originalLength = compressedImage.originalImage.Length;
var compressedLength =  compressedImage.compressedImage.Length;
var compressionRate = Math.Round(100 - (double)compressedLength / originalLength * 100, 2);

var decompressor = new Decompressor();
var decompressedImage = decompressor.DecompressImage(compressedImage.compressedImage);
var isLossless = decompressedImage.SequenceEqual(compressedImage.originalImage);

Console.WriteLine($"Original Image: {originalLength} bytes");
Console.WriteLine($"Compressed Image: {compressedLength} bytes");
Console.WriteLine($"Compression Rate: {compressionRate}%");
Console.WriteLine();
Console.WriteLine($"Decompressed Image: {decompressedImage.Length} bytes");
Console.WriteLine($"Is Lossless?: {isLossless}");
