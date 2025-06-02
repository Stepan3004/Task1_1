namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            int edgeLength = int.Parse(Console.ReadLine());

            double volume, surfaceArea;

            CalcCube(edgeLength, out volume, out surfaceArea);

            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");
        }

        static void CalcCube(int edgeLength, out double volume, out double surfaceArea)
        {
            volume = Math.Pow(edgeLength, 3);

            surfaceArea = 6 * Math.Pow(edgeLength, 2);
        }
    }
}
