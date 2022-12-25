namespace Indexers
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - Indexer : is a way to access elements in a class that represents a list of values
            */


            /*
            
            // - In case if there is not indexers
            HttpCookie cookie = new HttpCookie();
            cookie.SetItem("name", "Youssef Baba");
            Console.WriteLine(cookie.GetItem("name"));

            */


            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "John Doe";
            Console.WriteLine(cookie["name"]);

        }
    }
}