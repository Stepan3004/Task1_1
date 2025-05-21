namespace Task2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество построенных домов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int LastOne = n % 10;
            int LastTwo = n % 100;

            switch (LastTwo)
            {
                case 11:
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Мы построили {0} домов", n);
                    break;
                default:
                     switch (LastOne)
                    {
                        case 1:
                            Console.WriteLine("Мы построили {0} дом", n);
                            break;
                            case 2:
                            case 3:
                            case 4:
                            Console.WriteLine("Мы построили {0} домa", n);
                            break;
                        default:
                            Console.WriteLine("Мы построили {0} домов", n);
                            break;
                    }
                    break;

            }
        }
    }
}
