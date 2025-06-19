namespace Task14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> subscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            subscribers.Add("alice@example.com");
            subscribers.Add("bob@example.com");
            subscribers.Add("charlie@example.com");

            bool duplicateAdded = subscribers.Add("alice@example.com");
            Console.WriteLine($"Дубликат alice@example.com добавлен? {duplicateAdded}");

            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {subscribers.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {subscribers.Contains("dave@example.com")}");

            HashSet<string> newSubscribers = new HashSet<string>(new[] { "bob@example.com", "dave@example.com", "eve@example.com" });

            subscribers.UnionWith(newSubscribers);

            Console.WriteLine("Подписчики после объединения:");
            foreach (var sub in subscribers)
            {
                Console.WriteLine($"- {sub}");
            }

            var intersection = subscribers.Intersect(newSubscribers);
            Console.WriteLine("Общие подписчики:");
            foreach (var sub in intersection)
            {
                Console.WriteLine($"- {sub}");
            }

            bool removed = subscribers.Remove("charlie@example.com");
            Console.WriteLine($"Удалили charlie@example.com? {removed}");

            Console.WriteLine($"Всего подписчиков: {subscribers.Count}");

            HashSet<string> testGroup = new HashSet<string>(new[] { "alice@example.com", "bob@example.com" });
            bool isSubset = testGroup.IsSubsetOf(subscribers);
            Console.WriteLine($"testGroup является подмножеством? {isSubset}");

            subscribers.Clear();
            Console.WriteLine($"Подписчиков после очистки: {subscribers.Count}");
        }
    }
}
