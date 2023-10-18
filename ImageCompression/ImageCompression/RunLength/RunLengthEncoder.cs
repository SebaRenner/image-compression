namespace ImageCompression.RunLength;

public class RunLengthEncoder
{
    public byte[] RunLengthEncode(byte[] image)
    {
        var encodedBytes = new List<byte>();
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

            encodedBytes.Add((byte)count);
            encodedBytes.Add(current);

            pointer++;
        }

        return encodedBytes.ToArray();
    }
}
