using System.Drawing;
using System.IO;

namespace ImageCompression.ImageReader;

public class ImageReader
{
    public byte[] ReadImageBytes(string imagePath)
    {
        try
        {
            var bitmap = new Bitmap(imagePath);

            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }

            return imageBytes;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Reading image failed: {ex.Message}");
            return new byte[0];
        }
    }
}
