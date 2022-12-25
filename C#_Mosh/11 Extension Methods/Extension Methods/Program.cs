namespace Extension_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - Extension Methods : Allow us to add extensions method to an existing class without
                - Changing the code source of this class , or
                - Creating a new class that inherits from this class
             - Use extesion methods only when you really have to
             - In the real world most often we use extesion methods instead of creating them
            */

            string post = "This is supposed to be a very long blog post bla bla bla ...";
            string shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);

            IEnumerable<int> numbers = new List<int>() { 10, 20, 78, 1, 100, 94 };
            Console.WriteLine($"Largest value of list numbers = {numbers.Max()}");
        }
    }
}