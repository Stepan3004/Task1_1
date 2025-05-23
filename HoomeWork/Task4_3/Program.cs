namespace Task4_3
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
                array[i] = rnd.Next(0, 51);
                Console.Write("{0} ", array[i]);

            }

            int minValue = array[0];
            int maxValue = array[0];
            int minIndex = 0;
            int maxIndex = 0;


            for (int a = 1; a < n; a++)
            {
                if (array[a] < minValue)
                {
                    minValue = array[a];
                    minIndex = a;
                }

                if (array[a] > maxValue)
                {
                    maxValue = array[a];
                    maxIndex = a;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Минимальное значение: {0}, индекс: {1}", minValue, minIndex);
            Console.WriteLine("Максимальное значение: {0}, индекс: {1}", maxValue, maxIndex);
        }
        }
    }