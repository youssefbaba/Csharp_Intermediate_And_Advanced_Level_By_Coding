namespace Extension_Methods
{
    public class ExtensionMethods
    {
        // Constructors
        public ExtensionMethods(string name)
        {
            Name = name;
        }
        // Methods
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2");
        }

        //  Properties
        public string Name { get; set; }
    }
}
