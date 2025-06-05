namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите Ваш возраст: ");
                int userAge = int.Parse(Console.ReadLine());

                ValidateAge(userAge);

                Console.WriteLine("Ваш возраст корректен!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено неправильное значение возраста.");
            }
        }

        public static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Возраст не может быть отрицательным");
            }
            else if (age > 150)
            {
                throw new ArgumentOutOfRangeException("Слишком большой возраст"); 
            }
        }
    }
    
}
