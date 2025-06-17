namespace Task13_1
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { -3, 0, 5, -8, 12 }; 

            Transformer doubleNumbers = x => x * 2; 
            Transformer squareNumbers = x => x * x; 
            Transformer absoluteValue = x => Math.Abs(x); 

            int[] doubled = Transform(numbers, doubleNumbers);
            int[] squared = Transform(numbers, squareNumbers);
            int[] absValues = Transform(numbers, absoluteValue);

            Console.WriteLine("Исходный массив: " + String.Join(", ", numbers));
            Console.WriteLine("Удвоенные числа: " + String.Join(", ", doubled));
            Console.WriteLine("Возведенные в квадрат: " + String.Join(", ", squared));
            Console.WriteLine("Модули чисел: " + String.Join(", ", absValues));
        }

        delegate int Transformer(int number);

        static int[] Transform(int[] array, Transformer transformDelegate)
        {
            int[] transformedArray = new int[array.Length]; 

            for (int i = 0; i < array.Length; i++)
            {
                transformedArray[i] = transformDelegate(array[i]); 
            }

            return transformedArray;
        }
    }
}
