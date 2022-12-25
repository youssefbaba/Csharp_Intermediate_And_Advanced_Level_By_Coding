namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Book> books = new BookRepository().GetBooks();


            // Filtring Collection :
            //IEnumerable<Book> cheapBooks = books.Where(b => b.Price <= 10);
            List<Book> cheapBooks = books
                                    .Where(b => b.Price <= 10)
                                    .ToList();
            foreach (Book book in cheapBooks)
            {
                Console.WriteLine($"Title = {book.Title} - Price = {book.Price}");
            }


            Console.WriteLine();
            Console.WriteLine();


            // Sorting Collection by one createria : 
            List<Book> sortedBooksByTitle = books
                                            .Where(b => b.Price <= 10)
                                            .OrderBy(b => b.Title)
                                            .ToList();
            foreach (Book book in sortedBooksByTitle)
            {
                Console.WriteLine($"Title = {book.Title} - Price = {book.Price}");
            }


            Console.WriteLine();
            Console.WriteLine();


            // Sorting Collection by two createria : 
            List<Book> sortedBooksByTitleAndPrice = books
                                                    .Where(b => b.Price <= 10)
                                                    .OrderBy(b => b.Title)
                                                    .ThenByDescending(b => b.Price)
                                                    .ToList();
            foreach (Book book in sortedBooksByTitleAndPrice)
            {
                Console.WriteLine($"Title = {book.Title} - Price = {book.Price}");
            }


            Console.WriteLine();
            Console.WriteLine();


            // Select Title of book :
            List<string> listTitleBooks = books
                                          .Where(b => b.Price <= 10)
                                          .OrderBy(b => b.Title)
                                          .Select(b => b.Title)
                                          .ToList();
            foreach (string title in listTitleBooks)
            {
                Console.WriteLine(title);
            }


            Console.WriteLine();
            Console.WriteLine();


            // Select Price and Title of book :
            var obj = books
                      .Where(b => b.Price <= 10)
                      .OrderBy(b => b.Title)
                      .Select(b => new { b.Price, b.Title })
                      .ToList();
            foreach (var item in obj)
            {
                Console.WriteLine($"Price = {item.Price} - Title = {item.Title}");
            }


            Console.WriteLine();
            Console.WriteLine();


            // LINQ Extension Methods
            List<Book> listOfBooksOne = books
                                        .Where(b => b.Price <= 10)
                                        .OrderBy(b => b.Title)
                                        .ToList();
            foreach (Book book in listOfBooksOne)
            {
                Console.WriteLine($"Title = {book.Title} - Price = {book.Price}");
            }


            Console.WriteLine();
            Console.WriteLine();


            // LINQ Query Operators
            List<Book> listOfBooksTWo = (from b in books
                                         where b.Price <= 10
                                         orderby b.Title
                                         select b).ToList();
            foreach (Book book in listOfBooksTWo)
            {
                Console.WriteLine($"Title = {book.Title} - Price = {book.Price}");
            }


            Console.WriteLine();
            Console.WriteLine();


            // LINQ Extension Methods
            List<string> listTitlesBooksOne = books
                                              .Where(b => b.Price <= 10)
                                              .OrderBy(b => b.Title)
                                              .Select(b => b.Title)
                                              .ToList();
            foreach (string title in listTitlesBooksOne)
            {
                Console.WriteLine($"Title = {title}");
            }


            Console.WriteLine();
            Console.WriteLine();


            // LINQ Query Operators
            List<String> listTitlesBooksTwo = (from b in books
                                               where b.Price <= 10
                                               orderby b.Title
                                               select b.Title).ToList();
            foreach (string title in listTitlesBooksTwo)
            {
                Console.WriteLine($"Title = {title}");
            }








        }
    }
}