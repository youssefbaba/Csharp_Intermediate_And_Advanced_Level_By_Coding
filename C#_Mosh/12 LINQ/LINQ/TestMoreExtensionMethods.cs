namespace LINQ
{
    public class TestMoreExtensionMethods
    {
        static void Main(string[] args)
        {

            /*
            
             // LINQ Extension Methods
                - Where()
                - Single()
                - SingleOrDefault()

                - First()
                - FirstOrDefault()

                - Last()
                - LastOrDefault()

                - Min()
                - Max()
                - Sum()
                - Count()
                - Average()

                - Skip().Take()
                    
             */
            IEnumerable<Book> books = new BookRepository().GetBooks();

            // LINQ Extension Methods
            try
            {
                Book book1 = books.Single(b => b.Title == "Not Found"); // Throwing an exception
                Console.WriteLine($"Title = {book1.Title} - Price = {book1.Price}");

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            try
            {
                Book book2 = books.Single(b => b.Title == "ASP.Net MVC");
                Console.WriteLine($"Title = {book2.Title} - Price = {book2.Price}");

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            Book obj = books.SingleOrDefault(b => b.Title == "Not Found");
            if (obj != null)
            {
                Console.WriteLine($"Title = {obj.Title} - Price = {obj.Price}");
            }


            Console.WriteLine();
            Console.WriteLine();


            try
            {
                Book book3 = books.First(b => b.Title == "Not Found");
                Console.WriteLine($"Title = {book3.Title} - Price = {book3.Price}");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            try
            {
                Book book4 = books.First(b => b.Title == "ASP.Net MVC");
                Console.WriteLine($"Title = {book4.Title} - Price = {book4.Price}");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            Book book5 = books.FirstOrDefault(b => b.Title == "ASP.Net MVC");
            if (book5 != null)
            {
                Console.WriteLine($"Title = {book5.Title} - Price = {book5.Price}");
            }


            Console.WriteLine();
            Console.WriteLine();


            try
            {
                Book book6 = books.Last(b => b.Title == "Not Found");
                Console.WriteLine($"Title = {book6.Title} - Price = {book6.Price}");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            try
            {
                Book book7 = books.Last(b => b.Title == "C# Advanced Topics");
                Console.WriteLine($"Title = {book7.Title} - Price = {book7.Price}");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            Book book8 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            if (book8 != null)
            {
                Console.WriteLine($"Title = {book8.Title} - Price = {book8.Price}");
            }


            Console.WriteLine();
            Console.WriteLine();


            List<Book> listOfBooksOne = books.Skip(2).Take(3).ToList();
            foreach (Book book in listOfBooksOne)
            {
                Console.WriteLine($"Title = {book.Title} - Price = {book.Price}");
            }


            // Number Of elements in book list
            // High Price in book list
            // Lower Price in book list

            Console.WriteLine();
            Console.WriteLine();

            int numberOfBooks = books.Count();
            Console.WriteLine($"Number Of Books = {numberOfBooks}");


            Console.WriteLine();
            Console.WriteLine();


            float highPrice = books.Max(b => b.Price);
            Console.WriteLine($"High Price = {highPrice}");


            Console.WriteLine();
            Console.WriteLine();


            List<Book> subBooks = books.Where(b => b.Price <= 10).ToList();
            List<Book> listOfBooksTwo = subBooks.Where(b => b.Price == subBooks.Max(b => b.Price)).ToList();
            foreach (var item in listOfBooksTwo)
            {
                Console.WriteLine(item.Price);
            }


            Console.WriteLine();
            Console.WriteLine();


            float lowerPrice = books.Min(b => b.Price);
            Console.WriteLine($"Lower Price = {lowerPrice}");


            Console.WriteLine();
            Console.WriteLine();


            List<Book> subBooksOne = books.Where(b => b.Price <= 10).ToList();
            List<Book> listOfBooksThree = subBooks.Where(b => b.Price == subBooksOne.Min(b => b.Price)).ToList();
            foreach (var item in listOfBooksThree)
            {
                Console.WriteLine(item.Price);
            }


            Console.WriteLine();
            Console.WriteLine();


            float SumPrice = books.Sum(b => b.Price);
            Console.WriteLine($"Sum Price= {SumPrice}");


            Console.WriteLine();
            Console.WriteLine();

            float averagePrice = books.Average(b => b.Price);
            Console.WriteLine($"Average Price = {averagePrice}");
        }
    }
}
