namespace Task16_1
{
    class ComputerModel
    {
        public string ModelCode { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public float CPUFrequency { get; set; }
        public int RAMSizeGB { get; set; }
        public long HardDiskCapacityGB { get; set; }
        public int VideoMemoryGB { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public override string ToString()
        {
            return $"Код: {ModelCode}, Марка: {Brand}, Процессор: {ProcessorType}, ОЗУ: {RAMSizeGB} ГБ, Цена: {Price:c}, В наличии: {QuantityInStock} шт.";
        }
    }

    class Program
    {
        static void Main()
        {
            List<ComputerModel> computers = new List<ComputerModel>
            {
                new ComputerModel { ModelCode="CM-1001", Brand="Asus", ProcessorType="Intel Core i5", CPUFrequency=3.2f, RAMSizeGB=8, HardDiskCapacityGB=500, VideoMemoryGB=2, Price=800m, QuantityInStock=20 },
                new ComputerModel { ModelCode="CM-1002", Brand="Lenovo", ProcessorType="AMD Ryzen 5", CPUFrequency=3.5f, RAMSizeGB=16, HardDiskCapacityGB=1024, VideoMemoryGB=4, Price=1200m, QuantityInStock=15 },
                new ComputerModel { ModelCode="CM-1003", Brand="HP", ProcessorType="Intel Core i7", CPUFrequency=3.8f, RAMSizeGB=16, HardDiskCapacityGB=1024, VideoMemoryGB=8, Price=1500m, QuantityInStock=10 },
                new ComputerModel { ModelCode="CM-1004", Brand="Dell", ProcessorType="Intel Core i5", CPUFrequency=3.0f, RAMSizeGB=8, HardDiskCapacityGB=500, VideoMemoryGB=2, Price=750m, QuantityInStock=30 },
                new ComputerModel { ModelCode="CM-1005", Brand="Apple", ProcessorType="M1 Pro", CPUFrequency=3.2f, RAMSizeGB=16, HardDiskCapacityGB=512, VideoMemoryGB=16, Price=2000m, QuantityInStock=5 },
                new ComputerModel { ModelCode="CM-1006", Brand="MSI", ProcessorType="AMD Ryzen 7", CPUFrequency=4.0f, RAMSizeGB=32, HardDiskCapacityGB=2048, VideoMemoryGB=16, Price=1800m, QuantityInStock=12 },
            };

            Console.Write("Введите тип процессора для поиска: ");
            string processorTypeSearch = Console.ReadLine();
            var byProcessorType = computers.Where(c => c.ProcessorType == processorTypeSearch);
            Console.WriteLine($"Компьютеры с процессором {processorTypeSearch}:");
            foreach (var comp in byProcessorType)
            {
                Console.WriteLine(comp);
            }

            Console.Write("Введите минимальный объем оперативной памяти (ГБ): ");
            int minRAM = Convert.ToInt32(Console.ReadLine());
            var filteredByRAM = computers.Where(c => c.RAMSizeGB > minRAM); // Заменяем ">=" на ">"
            Console.WriteLine($"Компьютеры с объёмом ОЗУ более {minRAM} ГБ:");
            foreach (var comp in filteredByRAM)
            {
                Console.WriteLine(comp);
            }

            var sortedByPrice = computers.OrderBy(c => c.Price);
            Console.WriteLine("Компьютеры, отсортированные по возрастанию цены:");
            foreach (var comp in sortedByPrice)
            {
                Console.WriteLine(comp);
            }

            var groupedByProcessor = computers.GroupBy(c => c.ProcessorType);
            Console.WriteLine("Компьютеры, сгруппированные по типу процессора:");
            foreach (var group in groupedByProcessor)
            {
                Console.WriteLine($"Процессор: {group.Key}");
                foreach (var comp in group)
                {
                    Console.WriteLine(comp);
                }
            }

            var mostExpensive = computers.MaxBy(c => c.Price);
            var cheapest = computers.MinBy(c => c.Price);
            Console.WriteLine($"Самый дорогой компьютер: {mostExpensive}");
            Console.WriteLine($"Самый бюджетный компьютер: {cheapest}");

            bool anyLargeStock = computers.Any(c => c.QuantityInStock >= 30);
            Console.WriteLine($"Есть ли хотя бы один компьютер в количестве не менее 30 штук? {(anyLargeStock ? "Да" : "Нет")}");
        }
    }
}