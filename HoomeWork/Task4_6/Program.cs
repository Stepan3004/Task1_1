namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((i + j) % 2); 
                    if (j != n - 1)
                        Console.Write(" ");   
                }
                Console.WriteLine();        





            }
        }
    }
}