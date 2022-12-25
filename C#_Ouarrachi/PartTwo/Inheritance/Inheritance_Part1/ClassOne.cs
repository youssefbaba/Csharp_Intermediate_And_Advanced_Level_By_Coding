namespace Inheritance_Part1
{
    internal class ClassOne
    {  
        // Constructors
        public ClassOne()
        {
            Console.WriteLine("Parent class parameter-less contructor invoked.");
        }
        public ClassOne(int id)
        {
            Id = id;
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


        // Properties
        public int Id { get; set; }

    }
}
