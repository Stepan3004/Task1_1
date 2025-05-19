namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int c = n;
                while (c % 2 == 0)
                {
                    c /= 2;
                }

                if (c == 1)
                    Console.WriteLine("{0} является степенью двойки", n);
                else
                    Console.WriteLine("{0} НЕ является степенью двойки", n);
            }
        }
    }
}