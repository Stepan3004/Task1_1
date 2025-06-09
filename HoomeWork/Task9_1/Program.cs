namespace Task9_1
{
    internal class Program
    {
        static void Main()
        {
            Building building = new Building("Москва, Красная пл., 1", 150, 2000);
            building.DisplayInfo();

            Console.WriteLine();

            MultiBuilding multiBuilding = new MultiBuilding("Москва, Ленинградский просп., 35", 500, 1995, 10, true);
            multiBuilding.DisplayInfo();

            Console.WriteLine("\n--- Upcasting и Downcasting ---");

            Building buildingUpcast = multiBuilding; 
            Console.WriteLine("\nПосле upcasting:");
            buildingUpcast.DisplayInfo();

            if (buildingUpcast is MultiBuilding)
            {
                MultiBuilding multiDowncast = (MultiBuilding)buildingUpcast; 
                Console.WriteLine("\nПосле downcasting:");
                multiDowncast.DisplayInfo();

                var multiAs = buildingUpcast as MultiBuilding;
                if (multiAs != null)
                {
                    Console.WriteLine("\nПосле downcasting с as:");
                    multiAs.DisplayInfo();
                }
            }
        }
    }

    public class Building
    {
        protected string _address;    
        protected double _area;       
        protected int _yearBuilt;

        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
        }

        public int BuildingAge => DateTime.Now.Year - _yearBuilt;

        public virtual double CalculateTax()
        {
            return _area * 1000; 
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Здание по адресу: {_address}\nПлощадь: {_area:F2} м2\nГод постройки: {_yearBuilt}\nВозраст: {BuildingAge} лет");
            Console.WriteLine($"Размер налога: {CalculateTax():F2}");
        }
    }

    public sealed class MultiBuilding : Building
    {
        private int _floors;     
        private bool _hasElevator; 

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }

        public double AreaPerFloor => _area / _floors;

        public override double CalculateTax()
        {
            double taxBase = base.CalculateTax();                 
            double floorFactor = 1 + (_floors - 1) * 0.05;      
            double elevatorSurcharge = _hasElevator ? 5000 : 0; 
            return taxBase * floorFactor + elevatorSurcharge;
        }

        
        public override void DisplayInfo()
        {
            base.DisplayInfo();                                 
            Console.WriteLine($"Количество этажей: {_floors}\nЛифт имеется: {_hasElevator}\nСредняя площадь на этаж: {AreaPerFloor:F2} м2");
        }
    }

}

