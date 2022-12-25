namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{ Title = "Title 1" , Price = 7},
                new Book{ Title = "Title 2" , Price = 4},
                new Book{ Title = "Title 3" , Price = 17},
                new Book{ Title = "Title 4" , Price = 9},
                new Book{ Title = "Title 5" , Price = 20}
            };
        }
    }
}