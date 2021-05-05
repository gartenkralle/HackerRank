private static string ReadLine()
{
    int READLINE_BUFFER_SIZE = 1000000;

    Stream inputStream = Console.OpenStandardInput(READLINE_BUFFER_SIZE);

    byte[] bytes = new byte[READLINE_BUFFER_SIZE];
    int outputLength = inputStream.Read(bytes, 0, READLINE_BUFFER_SIZE);
    char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);

    return new string(chars);
}
