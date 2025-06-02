namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите числа через запятую: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');
            int[] numbers = Array.ConvertAll(parts, part => int.Parse(part.Trim()));

            int maxNumber = FindMax(numbers);

            Console.WriteLine($"Максимальное число: {maxNumber}");
        }

        static int FindMax(params int[] nums)
        {
            if (nums.Length == 0)
                throw new InvalidOperationException("Массив пуст");

            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return max; ;
        }
    }
}
