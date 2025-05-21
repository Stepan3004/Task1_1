namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  число:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (-10 < a && a < 10)
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

