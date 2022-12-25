namespace Generics
{
    public class BookList
    {
        // Methods
        public void Add(Book book)
        {
            // Some statements here ...
        }
        public Book this[int index]
        {
            get
            {
                // Some statements here ...
                return new Book();
            }
        }
    }
}
