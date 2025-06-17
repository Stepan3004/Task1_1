namespace Task12_2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите текст для шифровки: ");
            string text = Console.ReadLine().Trim();

            string encryptedText = EncryptAtbash(text);
            Console.WriteLine($"Зашифрованный текст: {encryptedText}");

            string decryptedText = DecryptAtbash(encryptedText);
            Console.WriteLine($"Расшифрованный текст: {decryptedText}");
        }

        static string EncryptAtbash(string text)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (char.IsLetter(currentChar))
                {
                    char baseChar = char.IsUpper(currentChar) ? 'A' : 'a';
                    char lastChar = char.IsUpper(currentChar) ? 'Z' : 'z';

                    result[i] = (char)(lastChar - (currentChar - baseChar));
                }
                else
                {
                    result[i] = currentChar;
                }
            }

            return new string(result);
        }

        static string DecryptAtbash(string text)
        {
            return EncryptAtbash(text);
        }
    }
}