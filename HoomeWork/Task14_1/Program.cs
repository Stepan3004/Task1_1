namespace Task14_1
{
    internal class Program
    {
        static void Main()
        {
            List<string> players = new List<string>();

            players.Add("Иванов");    
            players.Add("Петров");    
            players.Add("Сидоров");

            players.Insert(1, "Козлов");

            bool containsPetrov = players.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {containsPetrov}");

            players.Remove("Сидоров");

            int indexKozlov = players.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов': {indexKozlov}");

            players.Sort();

            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {players[i]}");
            }

            bool isEmpty = players.Count == 0;
            Console.WriteLine($"Команда пуста? {isEmpty}");

            players.Clear();

            Console.WriteLine($"Количество игроков после очистки: {players.Count}");
        }
    }
    
}
