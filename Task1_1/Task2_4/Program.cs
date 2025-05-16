using System;

namespace Task2_4
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

            if ((a >= b && a <= c) || (a >= c && a <= b))
            {
                Console.WriteLine("Медиана: " + a);
            }
            else if
                ((b >= a && b <= c) || (b >= c && b <= a))
            {
                Console.WriteLine("Медиана: " + b);
            }
            else
            {
                Console.WriteLine("Медиана: " + c);
            }



        }
    }
}
