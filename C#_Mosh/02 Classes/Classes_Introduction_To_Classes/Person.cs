
namespace Classes_Introduction_To_Classes
{
    internal class Person
    {
        // Fields : Auto-Implemented readonly property
        public string Name { get; }

        // Constructor : 
        // Default constructor that takes no arguments
        public Person()
        {
            Name = "Unknown";
        }
        // Overload constructor that takes one argument
        public Person(string name)
        {
            Name = name;
        }

        // Methods :
        // Method that overrides ToString() method of class Object
        public override string ToString()
        {
            return $"Your name is {Name}";
        }
    }
}
