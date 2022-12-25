namespace Generics_Whats_And_Whys
{
    // we want to store books in the list
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotFiniteNumberException();
        }
        public Book this[int index]
        {
            get { throw new NotFiniteNumberException(); }
        }
    }
}
