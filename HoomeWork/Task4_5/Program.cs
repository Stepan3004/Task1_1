namespace Task4_5
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
                array[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            
            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 0; j < n / 2 - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = n / 2; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
