using System.Reflection.Metadata.Ecma335;

namespace Task8_1
{
    internal class Program
    {
        static void Main()
        {
            Book book = new Book("Колобо", "Михаил Булгаков", 1967, 448);
            Console.WriteLine(book.GetInfo());
        }
    }

    public class Book
    {

        private string title;
        private string author;

        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string bookTitle, string bookAuthor, int year, int pages)
        {
            title = bookTitle;
            author = bookAuthor;
            Year = year;
            Pages = pages;
        }

        public string GetInfo()
        {
            return $"{title}, {author}, {Year}, {Pages} стр.";
        }
    }
}