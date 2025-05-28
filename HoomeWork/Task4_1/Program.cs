namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;

            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                Console.Write("{0} ", array[i]);
            }

            int even = 0;
            int odd = 0;


            foreach (int a in array)
            {
                if (a % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine();

            if (even > odd)
            {
                Console.WriteLine("Четных чисел больше ({0}).", even);
            }
            else if (even < odd)
            {
                Console.WriteLine("Нечетных чисел больше ({0}).", odd);
            }
            else
            {
                Console.WriteLine("Количество четных и нечетных чисел одинаково.");

            }
        }
    }
}