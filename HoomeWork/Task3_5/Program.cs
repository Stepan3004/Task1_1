namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите число от 20 до 60: ");

                int a = Convert.ToInt32(Console.ReadLine());

                if (a >= 20 && a <= 60)
            {
                    Console.WriteLine("Вы ввели корректное число");
                    break;
            }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число. Повторите ввод.");
                }
              

            }


        }
    }
}
