namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string input1 = Console.ReadLine();

            Console.Write("Введите второе число: ");
            string input2 = Console.ReadLine();

            if (IsInteger(input1) && IsInteger(input2))
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
                Console.WriteLine(Multiply(num1, num2));
            }
            else
            {
                double num1 = double.Parse(input1);
                double num2 = double.Parse(input2);
                Console.WriteLine(Multiply(num1, num2));
            }
        }

        private static bool IsInteger(string value)
        {
            return int.TryParse(value, out _);
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
    
}
