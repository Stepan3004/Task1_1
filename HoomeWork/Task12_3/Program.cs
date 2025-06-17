namespace Task12_3
{
    internal class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.Start();
        }
    }

    abstract class Character
    {
        public string Name { get; }
        public int Damage { get; }

        protected int _health;

        public int Health => _health;

        public Character(string name, int health, int damage)
        {
            Name = name;
            _health = health;
            Damage = damage;
        }

        public bool IsAlive => _health > 0;

        public void ReduceHealth(int damage)
        {
            _health -= damage;
        }

        public virtual void Attack(Character target)
        {
            target.ReduceHealth(Damage); 
            Console.WriteLine($"{Name} наносит {Damage} урона {target.Name}!");
        }
    }

    class Player : Character
    {
        private const int HEALTH_POTION_HEAL_AMOUNT = 10;
        private const int MAX_HEALTH_POTIONS = 3;
        private int remainingHealthPotions = MAX_HEALTH_POTIONS;

        public Player(string name) : base(name, 30, 5) { } 

        public void UseHealthPotion()
        {
            if (remainingHealthPotions > 0)
            {
                _health += HEALTH_POTION_HEAL_AMOUNT;
                remainingHealthPotions--;
                Console.WriteLine($"{Name} выпил зелье здоровья (+{HEALTH_POTION_HEAL_AMOUNT})!");
            }
            else
            {
                Console.WriteLine("Нет зелий здоровья!");
            }
        }

        public void TakeTurn(Monster monster)
        {
            Console.WriteLine("Ваш ход:\n1 - Атаковать\n2 - Использовать зелье здоровья");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Attack(monster);
                    break;
                case "2":
                    UseHealthPotion();
                    break;
                default:
                    Console.WriteLine("Неправильный выбор. Пропуск хода.");
                    break;
            }
        }
    }

    class Monster : Character
    {
        private Random rnd = new Random();

        public Monster() : base("Злобный Гоблин", 20, 0) { }

        public override void Attack(Character target)
        {
            int randomDamage = rnd.Next(1, 7);
            target.ReduceHealth(randomDamage);
            Console.WriteLine($"{Name} наносит {randomDamage} урона {target.Name}!");
        }

        public void TakeTurn(Player player)
        {
            Attack(player);
        }
    }

    class Game
    {
        public void Start()
        {
            do
            {
                PlayRound();
                Console.WriteLine("Хотите сыграть снова? (Y/N)");
            } while (Console.ReadLine().ToLower() == "y");
        }

        private void PlayRound()
        {
            Console.WriteLine("=== Игра 'Битва с монстром' ===");
            Console.Write("Введите имя вашего персонажа: ");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);
            Monster monster = new Monster();

            Console.WriteLine($"Битва начинается! {player.Name} против {monster.Name}!");

            while (player.IsAlive && monster.IsAlive)
            {
                player.TakeTurn(monster);

                if (!monster.IsAlive)
                {
                    break;
                }

                monster.TakeTurn(player);

                Console.WriteLine($"Текущее состояние:\n{player.Name}: {player.Health} HP\n{monster.Name}: {monster.Health} HP");
            }

            if (player.IsAlive)
            {
                Console.WriteLine($"{player.Name} победил!");
            }
            else
            {
                Console.WriteLine($"{monster.Name} одержал победу...");
            }
        }
    }
}
