namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1*2*3...*n
           int n = Convert.ToInt32(Console.ReadLine());
           int s = 1;

            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);


        }
    }
}
