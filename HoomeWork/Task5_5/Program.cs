using System.Text.RegularExpressions;

namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex phoneRegex = new Regex(@"^\+\d{1}\(\d{3}\)\d{3}-\d{2}-\d{2}$");

            Console.Write("Введите номер телефона в формате +7(XXX)XXX-XX-XX: ");
            string userPhoneNumber = Console.ReadLine();

            bool isValid = phoneRegex.IsMatch(userPhoneNumber);

            if (isValid)
            {
                Console.WriteLine("Номер телефона корректен.");
            }
            else
            {
                Console.WriteLine("Номер телефона некорректен.");
            }
          

            
        }
    }
}
