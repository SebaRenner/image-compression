using ImageCompression.Compressor;

Console.WriteLine("input path to image");
var input = string.Empty;

input = Console.ReadLine();

var compressor = new Compressor();
var compressedImage = compressor.CompressImage(input);


