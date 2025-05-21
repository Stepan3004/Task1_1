namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  число:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 2;
            if (b != 0)
            {
                Console.Write("нет");
            }
            else
            {
                Console.Write("да");
            }
        }
    }
}
