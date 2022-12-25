namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - Lambda Expression is an anonymous method :
                    - No access modifier
                    - No name
                    - No return statement


             - Syntax of Lambda Expression : Args => Expression = Arguments LambdaOperator Expression
             - () => expression     = if we don't need any argument
             - arg => expression   = if we need just only one arggument
             - (arg1 , arg2 , arg3 , ....) => expression  = if we need multiple argument
            */

            // Anonymous Method :
            Func<double, double> squareOne = delegate (double number)
            {
                return number * number;
            };
            Console.WriteLine($"Square of 5 = {squareOne(5)}");


            // Lambda Expression
            Func<double, double> squareTwo = number => number * number;
            Console.WriteLine($"Square of 8.5 = {squareTwo(8.5)}");


            const int factor = 5;
            Func<double, double> multiplier = value => value * factor;
            Console.WriteLine($"The result of 10 * 5 = {multiplier(10)}");


            List<Book> books = new BookRepository().GetBooks();
            List<Book> cheapBooks = books.FindAll(book=>book.Price <= 10);
            foreach (Book book in cheapBooks)
            {
                Console.WriteLine($"Title = {book.Title} - Price = {book.Price}");
            }
        }
    }
}