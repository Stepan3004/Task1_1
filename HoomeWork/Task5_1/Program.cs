namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            if (words.Length > 0)
            {
                string longestWord = "";

                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                        longestWord = word;
                }

                Console.WriteLine($"Самое длинное слово: {longestWord}");
            }
            else
            {
                Console.WriteLine("Предложение пустое.");
            }
        }
    }
}
