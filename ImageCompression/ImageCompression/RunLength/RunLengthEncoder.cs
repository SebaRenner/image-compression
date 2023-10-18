namespace ImageCompression.RunLength;

public class RunLengthEncoder
{
    public string RunLengthEncode(byte[] image)
    {
        var code = string.Empty;
        while (image.Length > 0)
        {
            var pointer = 0;
            var current = image[pointer];

            while (pointer < image.Length && current.Equals(image[pointer++]))
            {
                pointer++;
                current = image[pointer];
            }

            var combination = $"{pointer}{image[pointer]}";
            code += combination;

            image = image.Skip(pointer).ToArray();
        }

        return code;
    }
}
