namespace ImageCompression.RunLength;

public class RunLengthEncoder
{
    public string RunLengthEncode(byte[] image)
    {
        var code = string.Empty;
        var pointer = 0;

        while (pointer < image.Length)
        {
            var current = image[pointer];
            var count = 1;

            while (pointer < image.Length - 1  && current.Equals(image[pointer + 1]))
            {
                pointer++;
                count++;
            }

            code += $"{count}{(char)image[pointer]}";

            pointer++;
        }

        return code;
    }
}
