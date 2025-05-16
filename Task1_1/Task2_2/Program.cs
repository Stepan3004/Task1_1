using System;

namespace Task2_2
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

            int max1 = Math.Max (a, b);
            int max2 = Math.Max (c, max1);

            Console.Write("Наибольшее число:{0}", max2);
        }
    }
}
