using ImageCompression.Compressor;

Console.WriteLine("input path to image");
var input = string.Empty;

input = Console.ReadLine();

var compressor = new Compressor();
var compressedImage = compressor.CompressImage(input);

var originalLength = compressedImage.originalImage.Length;
var compressedLength =  compressedImage.compressedImage.Length;
var compressionRate = Math.Round(100 - (double)compressedLength / originalLength * 100, 2);

Console.WriteLine($"Original Image: {originalLength} bytes");
Console.WriteLine($"Compressed Image: {compressedLength} bytes");
Console.WriteLine($"Compression Rate: {compressionRate}%");