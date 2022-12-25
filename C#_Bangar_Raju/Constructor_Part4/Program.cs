namespace Constructor_Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - Static constructor is called automatically at most one time before the first instance is created or any static members are referenced.
             */
            StaticInstanceConDemo staticInstanceConDemo1 = new StaticInstanceConDemo(10);
            StaticInstanceConDemo staticInstanceConDemo2 = new StaticInstanceConDemo(10);
            StaticInstanceConDemo staticInstanceConDemo3 = new StaticInstanceConDemo(10);
            Console.WriteLine(staticInstanceConDemo1.Value);
            Console.WriteLine(staticInstanceConDemo2.Value);
            Console.WriteLine(staticInstanceConDemo3.Value);
            Console.WriteLine(StaticInstanceConDemo.Date);
        }
    }
}