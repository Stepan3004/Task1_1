namespace Task2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ширина участка (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Длина участка (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Размеры первого дома (p x q): ");
            Console.Write("размер (p): ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("размер (q): ");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.Write("Размеры второго дома (r x s): ");
            Console.Write("размер (r): ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("размер (s): ");
            int s = Convert.ToInt32(Console.ReadLine());

            
            int Var1 = p + r;
            int Var2 = q + s;
            int Var3 = p + s;
            int Var4 = q + r;

            int proverka = 0;

            if (Var1 <= a && b >= Math.Max(q, s) || Var1 <= b && a >= Math.Max(q, s))
            {
                proverka = + 1;
            }
            if (Var2 <= a && b >= Math.Max(q, s) || Var2 <= b && a >= Math.Max(q, s))
            {
                proverka = +1;
            }
            if (Var3 <= a && b >= Math.Max(q, s) || Var3 <= b && a >= Math.Max(q, s))
            {
                proverka = +1;
            }
            if (Var4 <= a && b >= Math.Max(q, s) || Var4 <= b && a >= Math.Max(q, s))
            {
                proverka = +1;
            }

            if (proverka != 0)
            {
                Console.Write("Дома можно расположить на усатке =)");
            }
            else
            {
                
                Console.Write("Дома нельзя расположить на усатке =(");
            }

            }
    }
}
