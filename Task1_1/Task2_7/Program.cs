namespace Task__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  число:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 9 && a < 100 || a < -9 && a > -100)
            {
                Console.Write("да");
            }
            else
            {
                Console.Write("нет");
            }
        }
    }
}
