namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int s = 1;

            for (int i = 1; i <= b; i++)
            {
                s *= a;
            }

            Console.WriteLine("{0}^{1} = {2}", a, b, s);
        }
    }
}
