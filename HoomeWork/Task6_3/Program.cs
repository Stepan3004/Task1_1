namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); 
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(1, 101);

            PrintNumbers(numbers);       

            PrintNumbers(numbers, true);   
        }

      
        static void PrintNumbers(int[] array, bool reverse = false)
        {
            if (!reverse)
            {
                foreach (var num in array)
                    Console.Write($"{num} ");
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                    Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
