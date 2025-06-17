namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] firstArray =
            {
            new Book<string, int>("F-1234", "Приключения Шерлока Холмса", 1892, "Артур Конан Дойл"),
            new Book<string, int>("F-5678", "Отверженные", 1862, "Виктор Гюго")
        };

            Book<int, string>[] secondArray =
            {
            new Book<int, string>(42, "Античная литература", "Древнегреческий период", "Гомер"),
            new Book<int, string>(24, "История средневековья", "Средние века", "Джордан Брандон")
        };

            var foundBookFirst = BookHelper.FindBook(firstArray, "F-1234");
            if (foundBookFirst != null)
            {
                Console.WriteLine(foundBookFirst.ToString());
            }
            else
            {
                Console.WriteLine("Книга не найдена");
            }

            var foundBookSecond = BookHelper.FindBook(secondArray, 42);
            if (foundBookSecond != null)
            {
                Console.WriteLine(foundBookSecond.ToString());
            }
            else
            {
                Console.WriteLine("Книга не найдена");
            }
        }
    }
    public class Book<T, U>
    {

        public T Code { get; }
        public string Title { get; }
        public U PublicationYear { get; }
        public string Author { get; }


        public Book(T code, string title, U pubYear, string author)
        {
            Code = code;
            Title = title;
            PublicationYear = pubYear;
            Author = author;
        }

        public override string ToString()
        {
            return $"Код: {Code} ({typeof(T)}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U)})";
        }
    }

    public static class BookHelper
    {
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (var book in books)
            {
                if (EqualityComparer<T>.Default.Equals(book.Code, code))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
