namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите предложение: ");
            string input = Console.ReadLine().Trim();


            input = input.Replace(" ", "");


            input = input.ToLower();


            int startIndex = 0;
            int endIndex = input.Length - 1;

            bool isPalindrome = true;

            while (startIndex < endIndex)
            {
                if (input[startIndex] != input[endIndex])
                {
                    isPalindrome = false;
                    break;
                }

                startIndex++;
                endIndex--;
            }

            if (isPalindrome)
                Console.WriteLine("Строка является палиндромом!");
            else
                Console.WriteLine("Строка НЕ является палиндромом.");
        }
    }
}

