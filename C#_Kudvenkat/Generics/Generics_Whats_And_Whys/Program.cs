using static System.Reflection.Metadata.BlobBuilder;

namespace Generics_Whats_And_Whys
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            
            IntegerList integerList= new IntegerList();
            integerList.Add(1);
            integerList.Add(2);
            integerList.Add(3);

            BookList bookList = new BookList();
            bookList.Add(new Book { Title = "Csharp Basic", Price = 50 });
            bookList.Add(new Book { Title = "Csharp Intermediate", Price = 70 });
            bookList.Add(new Book { Title = "Csharp Advanced", Price = 90 });

            ObjectList intlist = new ObjectList();
            intlist.Add(1);
            intlist.Add(2);
            intlist.Add(3);

            ObjectList booklist = new ObjectList();
            booklist.Add(new Book { Title = "Csharp Basic", Price = 50 });
            booklist.Add(new Book { Title = "Csharp Intermediate", Price = 70 });
            booklist.Add(new Book { Title = "Csharp Advanced", Price = 90 });

            */


            /*
            // I want to store list of numbers
            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            
            // I want to store list of books
            GenericList<Book> books = new GenericList<Book>();
            books.Add(new Book { Title = "Csharp Basic" , Price = 50} );
            books.Add(new Book { Title = "Csharp Intermediate" , Price = 70} );
            books.Add(new Book { Title = "Csharp Advanced" , Price = 90} );
            */


            /*
            GenericDictionary<string, Book> bookDictionary = new GenericDictionary<string, Book>();
            bookDictionary.Add("123", new Book { Title = "Csharp Basic", Price = 50 });
            bookDictionary.Add("145", new Book { Title = "Csharp Intermediate", Price = 70 });
            bookDictionary.Add("456", new Book { Title = "Csharp Advanced", Price = 90 });
            */


            /*
            Utilities utilities = new Utilities();
            Console.WriteLine($"Max = {utilities.Max(10, 5)}");
            Console.WriteLine($"Max = {utilities.Max("Ahmed", "Youssef")}");
            */



            Nullable<int> number = new Nullable<int>(10);
            Console.WriteLine($"Has Value ? {number.HasValue}"); // Has Value ? True
            Console.WriteLine($"Value : {number.GetValueOrDefault()}"); // Value : 10
            Console.WriteLine();


            Nullable<double> number1 = new Nullable<double>(10.5);
            Console.WriteLine($"Has Value ? {number1.HasValue}"); // Has Value ? True
            Console.WriteLine($"Value : {number1.GetValueOrDefault()}"); // Value : 10.5
            Console.WriteLine();


            Nullable<int> number2 = new Nullable<int>();
            Console.WriteLine($"Has Value ? {number2.HasValue}"); // Has Value ? False
            Console.WriteLine($"Value : {number2.GetValueOrDefault()}"); // Value : 0
            Console.WriteLine();



        }
    }
}