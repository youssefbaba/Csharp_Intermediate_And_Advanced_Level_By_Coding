namespace Generics_Part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> listNames = new GenericList<string>();
            listNames.Add("David");
            listNames.Add("Marks");
            listNames.Add("John");


            GenericList<int> listNumbers = new GenericList<int>();
            listNumbers.Add(10);
            listNumbers.Add(20);
            listNumbers.Add(30);


            Book book1 = new Book { Id = "ABC123", Title = "Title1" };
            Book book2 = new Book { Id = "AZE456", Title = "Title2" };
            Book book3 = new Book { Id = "QSD789", Title = "Title3" };
            GenericList<Book> listBooks = new GenericList<Book>();
            listBooks.Add(book1);
            listBooks.Add(book2);
            listBooks.Add(book3);


            GenericDictionary<string, Book> dictionaryBooks = new GenericDictionary<string, Book>();
            dictionaryBooks.Add(book1.Id, book1);
            dictionaryBooks.Add(book2.Id, book2);
            dictionaryBooks.Add(book3.Id, book3);


            Nullable<int> number = new Nullable<int>(10);
            Console.WriteLine($"Has value ? {number.HasValue}");  // True
            Console.WriteLine($"Value = {number.GetValueOrDefault()}"); // 10

            Nullable<double> number2 = new Nullable<double>();
            Console.WriteLine($"Has Value ? {number2.HasValue}");  // False
            Console.WriteLine($"Value = {number2.GetValueOrDefault()}");  // 0
        }
    }
}