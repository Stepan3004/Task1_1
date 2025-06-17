namespace Task12_1
{
    internal class Program
    {
        static void Main()
        {

            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            int attempts = 0;
            bool guessed = false;

            Console.WriteLine("Добро пожаловать в игру \"Угадай число\"!\nКомпьютер загадал число от 1 до 100.\nПопытайтесь угадать его.");

            while (!guessed)
            {
                Console.Write("Введите ваше предположение: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    continue;
                }

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Подсказка: Больше");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Подсказка: Меньше");
                }
                else
                {
                    guessed = true;
                    Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber}. Вам потребовалось {attempts} попыток.");
                }
            }
        }

    }
}