using System.Security.AccessControl;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
            
             - where T : IComparable => Interface = where T should be Implements interface IComparable
             - where T : Product => Class = Where T should be of type Product or any of its child
             - whare T : struct => struct = where T should be a value type
             - where T : class => class = where T should be a reference type
             - where T : new() => new() = where T should be an object that has a default constructor

             */


            Book book = new Book { Isbn = "1234", Title = "JavaScript" };
            BookList books = new BookList();
            books.Add(book);


            List numbers = new List();
            numbers.Add(10);


            StringList names = new StringList();
            names.Add("Youssef Baba");


            // Storing the books :
            Book book1 = new Book { Isbn = "2222", Title ="CSharp" };
            Book book2 = new Book { Isbn = "3333", Title = "Java" };
            Book book3 = new Book { Isbn = "4444", Title = "Angular" };
            GenericList<Book> listBooks = new GenericList<Book>();
            listBooks.Add(book1);
            listBooks.Add(book2);
            listBooks.Add(book3);


            // Storing the numbers :
            GenericList<int> listNumbers = new GenericList<int>();
            listNumbers.Add(100);
            listNumbers.Add(200);
            listNumbers.Add(300);


            // Storing the names :
            GenericList<string> listNames = new GenericList<string>();
            listNames.Add("David Huge");
            listNames.Add("Jordi Gea");
            listNames.Add("Marks Toti");


            GenericDictionary<string, Book> dictionaryBooks = new GenericDictionary<string, Book>();
            dictionaryBooks.Add(book1.Title, book1);
            dictionaryBooks.Add(book2.Title, book2);
            dictionaryBooks.Add(book3.Title, book3);


            Nullable<bool> booleanValue = new Nullable<bool>(true);
            Console.WriteLine($"Has Value ? {booleanValue.HasValue}"); // Has Value ? True
            Console.WriteLine($"Value : {booleanValue.GetValueOrDefault()}"); // Value : True

            Nullable<int> numberValue = new Nullable<int>();
            Console.WriteLine($"Has Value ? {numberValue.HasValue}"); // Has Value ? False
            Console.WriteLine($"Value : {numberValue.GetValueOrDefault()}"); // Value : 0



        }
    }

}