
namespace Classes_Introduction_To_Classes
{
    public  class ParentClass
    {
        // Constructor
        public ParentClass()
        {
            Console.WriteLine($"ParentClass Constructor Called.");
        }

        // Overload Constructor
        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }
}
