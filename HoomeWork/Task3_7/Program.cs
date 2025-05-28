namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;

            while (a > 0)
            {
                a /= 10;
                b++;
            }

            Console.WriteLine($"Кол-во цифр: {b}");
        }
    }
}
