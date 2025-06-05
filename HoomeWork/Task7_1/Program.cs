namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Выберите операцию:\n");
                Console.Write("1 — сложение\n");
                Console.Write("2 — вычитание\n");
                Console.Write("3 — умножение\n");
                Console.Write("4 — деление\n");
                Console.Write("Ваш выбор: ");
                string operationInput = Console.ReadLine();
                int operationCode = Convert.ToInt32(operationInput);

                switch (operationCode)
                {
                    case 1:
                        Console.WriteLine($"Результат сложения: {num1 + num2}");
                        break;

                    case 2:
                        Console.WriteLine($"Результат вычитания: {num1 - num2}");
                        break;

                    case 3:
                        Console.WriteLine($"Результат произведения: {num1 * num2}");
                        break;

                    case 4:
                        if (num2 != 0)
                            Console.WriteLine($"Частное чисел: {num1 / num2}");
                        else
                            throw new DivideByZeroException(); 
                        break;

                    default:
                        Console.WriteLine("Неверная операция.");
                        return;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! Вы ввели неверные данные. Попробуйте снова.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка! Деление на ноль невозможно.");
            }
        }
    }
}
