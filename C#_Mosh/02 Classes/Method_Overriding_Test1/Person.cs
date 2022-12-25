
namespace Method_Overriding_Test1
{
    public class Person
    {
        // Fields
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructors
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Methods
        public void Work()
        {
            Console.WriteLine($"It works...");
        }

        public virtual void Display()
        {
            Console.WriteLine($"Is person");
        }
    }
}
