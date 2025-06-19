namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>()
        {
            {"A001", 10 },
            {"B205", 25 },
            {"C307", 15 } 
        };

            bool exists = inventory.ContainsKey("B205");
            Console.WriteLine($"Товар с артикулом 'B205' существует? {exists}");

            inventory["A001"] = 8;

            if (inventory.TryGetValue("C307", out int headphonesQty))
            {
                Console.WriteLine($"Количество наушников: {headphonesQty}");
            }
            else
            {
                Console.WriteLine("Наушники отсутствуют на складе.");
            }

            inventory["B205"] += 5;

            inventory.Remove("C307");

            Console.WriteLine("Текущий инвентарь:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }

            bool isEmpty = inventory.Count == 0;
            Console.WriteLine($"Склад пуст? {isEmpty}");

            inventory.Clear();

            Console.WriteLine($"Количество товаров после очистки: {inventory.Count}");
        }
    }
}
