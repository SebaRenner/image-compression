using ImageCompression.Compressor;

Console.WriteLine("input path to image");
var input = string.Empty;

input = Console.ReadLine();

var compressor = new Compressor();
var compressedImage = compressor.CompressImage(input);

var originalLength = compressedImage.originalImage.Length;
var compressedLength =  compressedImage.compressedImage.Length;

Console.WriteLine($"Original Image: {originalLength} bytes");
Console.WriteLine($"Compressed Image: {compressedLength} bytes");