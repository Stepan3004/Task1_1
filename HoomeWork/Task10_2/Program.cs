namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = new IFlyable[]
            {
                new Bird(500),
                new Airplane(10000, 200)
            };

            foreach (IFlyable item in flyables)
            {
                item.Fly();
            }
        }
    }

    interface IFlyable
    {
        int MaxAltitude { get; }

        void Fly();
    }

    class Bird : IFlyable
    {
        public int MaxAltitude { get; }

        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }

    class Airplane : IFlyable
    {
        public int MaxAltitude { get; }

        public int CountPassengers { get; }

        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
        }
    }
}
