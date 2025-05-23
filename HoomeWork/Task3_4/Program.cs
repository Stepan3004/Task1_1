namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());


            double s = 1;

            for (int i = 1; i <= -b; i++)
            {
                s *= 1.0 / a;
            }

            Console.WriteLine("{0}^{1} = {2}", a, b, s);
        }
    }
}
