using System.Text;

namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var builder = new StringBuilder();

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();

            builder.AppendFormat("Имя: {0}, Возраст: {1}, Город: {2}", name, age, city);

            string result = builder.ToString();
            Console.WriteLine(result);
        }
    }
}
