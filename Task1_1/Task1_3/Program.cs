namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите длину в дюймах");
            int a = Convert.ToInt32(Console.ReadLine());

            double mm = a * 25.4;


            int meters = (int)mm / 1000;
            int centimeters = ((int)mm % 1000) / 10;
            double millimeters = ((int)mm % 1000) / 10 % 10;

            millimeters = Math.Round(millimeters, 1);

            
            Console.WriteLine("{0} дюйм = {1} М {2} СМ {3} ММ " , a, meters, centimeters, millimeters);
        }
    }
}
