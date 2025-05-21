namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите четвертое число:");
            int d = Convert.ToInt32(Console.ReadLine());

            int max1 = Math.Max(a, b);
            int max2 = Math.Max(c, max1);
            int max3 = Math.Max(d, max2);


            Console.Write("Наибольшее число:{0}", max3);
        }
    }
}
