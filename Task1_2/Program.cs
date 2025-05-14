namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите градусы");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите минуты");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите секунды");
            int c = Convert.ToInt32(Console.ReadLine());


            double g = a + b / 60.0 + c / 3600.0;
            double r = g * Math.PI / 180;

            Console.WriteLine("Результат в радианах: рад={0}", r);
        }
    }
}
