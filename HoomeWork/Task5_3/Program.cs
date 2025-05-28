namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();

            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите общую сумму продаж: "); 
            string rawTotalSalesAmount = Console.ReadLine();
            decimal totalSalesAmount = Convert.ToDecimal(rawTotalSalesAmount.Replace('.', ','));

            Console.Write("Введите количество проданных товаров: ");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());

            decimal averageItemPrice = Math.Round(totalSalesAmount / numberOfItems, 2);

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Отчёт о продажах за {month} {year}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Общая сумма продаж: {totalSalesAmount:n2} руб."); 
            Console.WriteLine($"Количество проданных товаров: {numberOfItems:n0} шт.");
            Console.WriteLine($"Средняя стоимость товара: {averageItemPrice:n2} руб.");
            Console.WriteLine("------------------------------");
        }
    }
}
