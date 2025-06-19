namespace Task16_1
{
    class Program
    {
        private const int DelayMs = 1000;

        public static async Task<int[]> GenerateArrayAsync(int size)
        {
            await Task.Delay(DelayMs);
            Random random = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 100);
            }
            return arr;
        }

        public static async Task<double> CalculateAverageAsync(int[] array)
        {
            await Task.Delay(DelayMs);
            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }

        private static async Task TestUsingContinueWith()
        {
            Console.WriteLine("Test using tasks continuation:");
            Task<int[]> generateTask = GenerateArrayAsync(10);
            generateTask.ContinueWith(task =>
            {
                Task<double> calculateTask = CalculateAverageAsync(task.Result);
                calculateTask.ContinueWith(t =>
                {
                    Console.WriteLine($"Среднее арифметическое: {t.Result}");
                });
            }).Wait();
        }

        private static async Task TestUsingAsyncAwait()
        {
            Console.WriteLine("Test using async/await:");
            int[] generatedArray = await GenerateArrayAsync(10);
            double average = await CalculateAverageAsync(generatedArray);
            Console.WriteLine($"Среднее арифметическое: {average}");
        }

        static async Task Main()
        {
            await TestUsingContinueWith();

            await TestUsingAsyncAwait();
        }
    }
}