using System;

namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] array = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 11);

                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();

            }

            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int max = array[i, 0];

                for (int j = 1; j < m; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j]; 
                    }
                }

                Console.WriteLine("Максимальный элемент в {0} строке: {1}", b++, max);
            }




        }
    }
}
