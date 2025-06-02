namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Введите первую сторону первого треугольника: ");
            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую сторону первого треугольника: ");
            int b1 = int.Parse(Console.ReadLine());

            Console.Write("Введите третью сторону первого треугольника: ");
            int c1 = int.Parse(Console.ReadLine());

            Console.Write("Введите первую сторону второго треугольника: ");
            int a2 = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую сторону второго треугольника: ");
            int b2 = int.Parse(Console.ReadLine());

            Console.Write("Введите третью сторону второго треугольника: ");
            int c2 = int.Parse(Console.ReadLine());

            double square1 = Square(a1, b1, c1);
            double square2 = Square(a2, b2, c2);

            Console.WriteLine($"Площадь первого треугольника: {square1}");
            Console.WriteLine($"Площадь второго треугольника: {square2}");

            if (square1 > square2)
            {
                Console.WriteLine("Площадь первого треугольника больше.");
            }
            else if (square1 < square2)
            {
                Console.WriteLine("Площадь второго треугольника больше.");
            }
            else
            {
                Console.WriteLine("Площадь обоих треугольников одинакова.");
            }
        }

        static double Square(int a, int b, int c)
        {
            double p = (a + b + c) / 2.0;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
