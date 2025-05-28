namespace Task4_2
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
                array[i] = rnd.Next(-20, 21);
                Console.Write("{0} ", array[i]);
            }

            int plus = 0;
            int minus = 0;
            int zero = 0;
            

            foreach (int a in array)
            {
                if (a > 0) plus++;
                if (a < 0) minus++;
                if (a==0) zero++;
            }

            Console.WriteLine();
            Console.WriteLine("Количество положительных чисел: {0}", plus);
            Console.WriteLine("Количество отрицательных чисел: {0}", minus);
            Console.WriteLine("Количество нулей: {0}", zero);




        }
    }
}
