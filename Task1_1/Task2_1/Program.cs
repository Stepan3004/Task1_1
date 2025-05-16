namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("{0}<{1}",a,b);
            }
            else if (a > b)
            {
                Console.WriteLine("{0}>{1}", a, b);
            }
            else
            {
                Console.WriteLine("{0}={1}", a, b);

            }
            Console.ReadKey();

           
        }
    }
}
